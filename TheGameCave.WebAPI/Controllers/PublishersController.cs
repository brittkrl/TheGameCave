using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheGameCave.WebAPI.Models;
using TheGameCave.WebAPI.Repositories;

namespace TheGameCave.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        readonly PublisherRepository _publisherRepository;

        public PublishersController(PublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        [HttpGet]
        public IActionResult GetPublishers()
        {
            return Ok(_publisherRepository.List());
        }

        [HttpGet("{id}")]
        public IActionResult GetPublisherById(int id)
        {
            return Ok(_publisherRepository.GetById(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher([FromRoute]int id, [FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != publisher.Id)
            {
                return BadRequest();
            }

            var updatedPublisher = await _publisherRepository.Update(publisher);
            if (updatedPublisher == null)
            {
                return NotFound();
            }

            return Ok(updatedPublisher);
        }

        //POST: api/Publisher
        [HttpPost]
        public async Task<IActionResult> PostPublisher([FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _publisherRepository.Add(publisher);

            return CreatedAtAction(nameof(GetPublisherById), new { id = publisher.Id }, publisher);
        }

        //DELETE: api/Publisher/4
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var publisher = await _publisherRepository.Delete(id);
            if (publisher == null)
            {
                return NotFound();
            }

            return Ok(publisher);
        }
    }
}
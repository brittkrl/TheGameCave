using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
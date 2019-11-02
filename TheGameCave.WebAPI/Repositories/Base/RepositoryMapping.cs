using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Data;

namespace TheGameCave.WebAPI.Repositories.Base
{
    public class RepositoryMapping<T> : RepositoryBase<T> where T : EntityBase
    {
        protected readonly IMapper _mapper;

        public RepositoryMapping(TheGameCaveContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
    }
}

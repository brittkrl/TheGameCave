﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Repositories.Base;

namespace TheGameCave.WebAPI.Repositories
{
    public class PublisherRepository : RepositoryBase<Publisher>
    {
        public PublisherRepository(TheGameCaveContext context) : base(context)
        {
        }
    }
}

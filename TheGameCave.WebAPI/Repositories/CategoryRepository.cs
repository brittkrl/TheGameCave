﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Data;
using TheGameCave.WebAPI.Repositories.Base;

namespace TheGameCave.WebAPI.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(TheGameCaveContext context) : base(context)
        {
        }
    }
}

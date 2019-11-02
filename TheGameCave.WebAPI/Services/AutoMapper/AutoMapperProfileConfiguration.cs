using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGameCave.Lib.DTO;
using TheGameCave.Lib.Models;

namespace TheGameCave.WebAPI.Services.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<ProductBasicDto, Product>().ReverseMap();
            CreateMap<Product, ProductDetail>();
        }
    }
}

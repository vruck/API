using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Repositorio;
using WEBAPI.Models;

namespace WebAPI.Mappers
{
    public class AutoMapperConfig:Profile
    {
        public static IMapper Mapper { get; private set; }

        public AutoMapperConfig()
        {
            CreateMap<produtos, ProdutosModel>();
            CreateMap<ProdutosModel,produtos>();
        }

      
    }
}
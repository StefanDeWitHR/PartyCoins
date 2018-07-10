using AutoMapper;
using WebAPI.Models;
using WebAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
{
    public class AutoMapperProfile : Profile
    {
        public  AutoMapperProfile()
        {
            CreateMap<Company, CompanyDTO>();
            CreateMap<CompanyDTO, Company>();

        }

    }
}

using AutoMapper;
using PartyCoinAPI.Models;
using PartyCoinAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyCoinAPI.Data
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

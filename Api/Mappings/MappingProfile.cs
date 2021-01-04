using Api.Dto;
using AutoMapper;
using Core.Entities;

namespace Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MobileDto,Mobile>();
            CreateMap<CharityDto,Charity>();
            CreateMap<CommunalDto,Communal>();
            CreateMap<FinanceDto,Finance>();
        }
    }
}
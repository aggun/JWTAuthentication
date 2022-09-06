using AutoMapper;
using PycApi.Data;
using PycApi.Dto;

namespace PycApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<AccountDto, Account>().ReverseMap();
        }

    }
}

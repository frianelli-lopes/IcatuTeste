using AutoMapper;
using IcatuTeste.API.ViewModels;
using IcatuTeste.Domain.Models;

namespace IcatuTeste.API.Automapper
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Cliente, CustomerViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Sexo))
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.DataNascimento))
                .ForMember(dest => dest.Document, opt => opt.MapFrom(src => src.CPF))
                .ReverseMap();
        }
    }
}

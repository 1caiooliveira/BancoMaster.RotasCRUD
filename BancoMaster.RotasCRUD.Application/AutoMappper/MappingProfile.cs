using AutoMapper;
using BancoMaster.RotasCRUD.Application.DTOs;
using BancoMaster.RotasCRUD.Domain.Entities;

namespace BancoMaster.RotasCRUD.Application.AutoMapper;
#nullable disable
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Local, LocalDto>().ReverseMap();

        CreateMap<Rota, RotaDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(r => r.Id))
            .ForMember(dest => dest.Origem, opt => opt.MapFrom(r => r.LocalOrigem.Nome))
            .ForMember(dest => dest.Destino, opt => opt.MapFrom(r => r.LocalDestino.Nome))
            .ForMember(dest => dest.Valor, opt => opt.MapFrom(r => r.Valor))
            .ReverseMap();
    }
}
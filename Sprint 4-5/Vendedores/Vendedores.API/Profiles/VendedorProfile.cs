using AutoMapper;
using Vendedores.Application.Dtos.Inputs;
using Vendedores.Application.Dtos.Outputs;
using Vendedores.Domain.Entidades;

namespace Vendedores.API.Profiles
{
    public class VendedorProfile : Profile
    {
        public VendedorProfile()
        {
            
            CreateMap<CreateVendedorDto, Vendedor>();
            CreateMap<Vendedor, GetVendedorDto>();
            CreateMap<EditVendedorDto, Vendedor>();
            CreateMap<Vendedor, VendedorByIdOutputDto>();
            CreateMap<Vendedor, VendedorOutputDto>().ReverseMap();

        }
    }
}

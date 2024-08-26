using AutoMapper;
using Biscoitinhos.application.DTO;
using Biscoitinhos.domain.Entidades;

namespace Biscoitinhos.application
{
  public class MappingEntidade : Profile
  {
    public MappingEntidade()
    {
      CreateMap<SKU, SKUDTO>().ReverseMap();
    }
  }
}

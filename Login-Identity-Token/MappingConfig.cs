using AutoMapper;
using Login_Identity_Token.Modelos.Dto;
using Login_Identity_Token.Modelos;

namespace Login_Identity_Token
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<UsuarioAplicacion, UsuarioDto>().ReverseMap();
        }
    }
}

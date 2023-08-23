using Login_Identity_Token.Modelos;
using Login_Identity_Token.Modelos.Dto;

namespace Login_Identity_Token.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        bool IsUsuarioUnico(string userName);

        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);

        Task<UsuarioDto> Registrar(RegistroRequestDTO registroRequestDTO);
    }
}

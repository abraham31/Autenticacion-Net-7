namespace Login_Identity_Token.Modelos.Dto
{
    public class LoginResponseDTO
    {
        public UsuarioDto Usuario { get; set; }
        public string Token { get; set; }

       // public string Rol { get; set; }
    }
}

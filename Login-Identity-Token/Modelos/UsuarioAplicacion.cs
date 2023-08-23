using Microsoft.AspNetCore.Identity;

namespace Login_Identity_Token.Modelos
{
    public class UsuarioAplicacion :IdentityUser
    {

        public string Nombres { get; set; }

    }
}

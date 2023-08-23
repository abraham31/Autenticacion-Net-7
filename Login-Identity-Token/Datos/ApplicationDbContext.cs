
using Login_Identity_Token.Modelos.Dto;
using Login_Identity_Token.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Login_Identity_Token.Datos
{
    public class ApplicationDbContext : IdentityDbContext<UsuarioAplicacion>
    { 


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UsuarioAplicacion> UsuariosAplicacion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}

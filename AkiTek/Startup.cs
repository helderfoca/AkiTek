using AkiTek.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AkiTek.Startup))]
namespace AkiTek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // invocar a função que vai criar ROLES + USERS
            iniciaAplicacao();

        }

        /// <summary>
        /// cria, caso não existam, as Roles de suporte à aplicação: Veterinario, Funcionario, Dono
        /// cria, nesse caso, também, um utilizador...
        /// </summary>
        private void iniciaAplicacao() {
            
            ApplicationDbContext db = new ApplicationDbContext();
            
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            
            // criar a Role 'Cliente'
            if (!roleManager.RoleExists("Cliente")) {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Cliente";
                roleManager.Create(role);
            }
            
            // criar a Role 'Gestor'
            if (!roleManager.RoleExists("Admin")) {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }
            
            // criar um utilizador 'Gestor'
            var user = new ApplicationUser();
            user.UserName = "admin@akitek.pt";
            user.Email = "admin@akitek.pt";
            //  user.Nome = "";
            string userPWD = "123_Asd";
            var chkUser = userManager.Create(user, userPWD);
            
            //Adicionar o Utilizador à respetiva Role
            if (chkUser.Succeeded) {
                var result1 = userManager.AddToRole(user.Id, "Admin");
            }

        }

    }
}

using System.Web.Mvc;

namespace s2bProjeto.Areas.Usuario
{
    public class UsuarioAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Usuario";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Usuario_default",
                "Usuario/{controller}/{action}/{id}",
                new {controller="Home",  action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
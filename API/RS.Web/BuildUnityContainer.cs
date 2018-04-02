using System.Security.Principal;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RS.Data.Interfaces;
using RS.Data.Logic;
using RS.Service.Interfaces;
using RS.Service.Logic;


namespace RS.Web
{
    public static class BuildUnityContainer
    {
        public static IServiceCollection RegisterAddTransient(IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IPrincipal>(
                provider => provider.GetService<IHttpContextAccessor>().HttpContext.User);

            #region Repository
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
            #endregion

            #region Services
            services.AddTransient<IRoleManagerService, RoleManager>();
            services.AddTransient<IUserService, UserManagerService>();
            services.AddTransient<ISkillManagerService, SkillManagerService>();
            #endregion

            return services;
        }
    }
}

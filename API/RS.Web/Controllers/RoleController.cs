using Microsoft.AspNetCore.Mvc;
using RS.Common.CommonData;
using RS.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace RS.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Role/[Action]")]
    [ValidateModel]
    [Authorize]
    public class RoleController : Controller
    {
        private readonly IRoleManagerService _roleManager;

        public RoleController(IRoleManagerService roleManager)
        {
            this._roleManager = roleManager;
          
        }

        [HttpGet]
        public IResult GetAllRole()
        {
            var rolelist = _roleManager.GetAllRole();
            return rolelist;
        }

        [HttpGet]
        public IResult GetRoleById(int id)
        {
            dynamic roleRecord = _roleManager.GetRoleById(id);
            return roleRecord;
        }
    }
}
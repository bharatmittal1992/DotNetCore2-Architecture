using Microsoft.AspNetCore.Mvc;
using RS.Common.CommonData;
using RS.Common.Extensions;
using RS.Service.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace RS.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/User/[Action]")]
    [ValidateModel]
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var details = GenericHelper.GetUserClaimDetails(identity);
            return new ObjectResult(details);
        }

    }
}
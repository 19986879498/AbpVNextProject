using AbpVNextProject.Application.User;
using Microsoft.AspNetCore.Mvc;

namespace AbpVNextProject.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserAppService _userAppService;
        public LoginController(IUserAppService userAppService)
        {
            this._userAppService = userAppService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public bool CheckLogin(string userNo,string password){
          var dto = _userAppService.Get(userNo,password);
          return dto!=null;
        }
    }
}
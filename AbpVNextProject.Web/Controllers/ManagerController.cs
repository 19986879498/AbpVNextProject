using System.Collections.Generic;
using AbpVNextProject.Application.Role;
using AbpVNextProject.Application.Role.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AbpVNextProject.Web.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IRoleAppService _roleAppService;
        public ManagerController(IRoleAppService roleAppService)
        {
            this._roleAppService = roleAppService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public List<RoleDto> GetAll(){
            return _roleAppService.GetAll();
        }
        // public bool Add([FromBody] RoleInputDto input){
        //     // RoleInputDto input = new RoleInputDto{
        //     //     RoleName = roleName
        //     // };
        //    return _roleAppService.Add(input);
        // }
        public bool Add(string roleName)
        {
            RoleInputDto input = new RoleInputDto
            {
                RoleName = roleName,
            };
            return _roleAppService.Add(input);
        }
    }
}
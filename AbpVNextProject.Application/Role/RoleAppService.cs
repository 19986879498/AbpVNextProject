using System.Collections.Generic;
using System.Linq;
using AbpVNextProject.Application.Role.Dto;
using AbpVNextProject.Domain.UserInfo;
using AbpVNextProject.EntityFrameworkCore;
using Volo.Abp.Application.Services;

namespace AbpVNextProject.Application.Role
{
    public class RoleAppService : ApplicationService, IRoleAppService
    {
        private readonly AbpVNextProjectDbContext _context;
        public RoleAppService(AbpVNextProjectDbContext context)
        {
            this._context = context;

        }
        public List<RoleDto> GetAll(){
           var roles = _context.Roles.ToList();
           return ObjectMapper.Map<List<Roles>,List<RoleDto>>(roles);
        }
        public bool Add(RoleInputDto input)
        {
            try
            {
                var role = ObjectMapper.Map<RoleInputDto, Roles>(input);
                role.IsDel = false;
                _context.Roles.Add(role);
                _context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }

        }
    }
}
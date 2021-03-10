using System.Collections.Generic;
using AbpVNextProject.Application.Role.Dto;
using Volo.Abp.Application.Services;

namespace AbpVNextProject.Application.Role
{
    public interface IRoleAppService:IApplicationService
    {
        bool Add(RoleInputDto input);
        List<RoleDto> GetAll();
    }
}
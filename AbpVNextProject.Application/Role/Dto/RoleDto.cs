using Volo.Abp.Application.Dtos;

namespace AbpVNextProject.Application.Role.Dto
{
    public class RoleDto:EntityDto<int>
    {
        public string RoleName { get; set; }
        public bool IsDel { get; set; }
        
    }
}
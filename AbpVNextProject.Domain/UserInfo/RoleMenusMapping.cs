using Volo.Abp.Domain.Entities;

namespace AbpVNextProject.Domain.UserInfo
{
public class RoleMenusMapping:Entity<int>
{
    public int RoleId { get; set; }
    public int MenuId { get; set; }
}
}
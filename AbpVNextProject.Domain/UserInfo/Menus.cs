using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace AbpVNextProject.Domain.UserInfo
{
    public class Menus : Entity<int>
    {
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string ActionName { get; set; }
        public int ParentMenuId { get; set; }
    }
}

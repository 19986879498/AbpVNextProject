using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace AbpVNextProject.Application.User.Dto
{
    public class UserDto:EntityDto<int>
    {
        public string UserNo { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
    }
}

using AbpVNextProject.Application.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpVNextProject.Application.User
{
    public interface IUserAppService:IApplicationService
    {
        List<UserDto> Get();
        UserDto Get(string userNo,string password);
    }
}

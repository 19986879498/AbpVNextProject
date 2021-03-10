using AbpVNextProject.Application.User.Dto;
using AbpVNextProject.Domain.UserInfo;
using AbpVNextProject.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpVNextProject.Application.User
{
    public class UserAppService:ApplicationService,IUserAppService
    {
        private readonly AbpVNextProjectDbContext _context;

        public UserAppService(AbpVNextProjectDbContext context)
        {
            _context = context;
        }

        public List<UserDto> Get() {
           var users = _context.Users.ToList();
           return ObjectMapper.Map<List<Users>, List<UserDto>>(users);
        }

        public UserDto Get(string userNo,string password){
           var user = _context.Users.FirstOrDefault(m=>m.UserNo == userNo && m.Password == password);
           var userDto = ObjectMapper.Map<Users,UserDto>(user);
           return userDto;
        }
    }
}

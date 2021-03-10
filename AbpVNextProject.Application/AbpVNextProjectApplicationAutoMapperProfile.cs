using AbpVNextProject.Application.Role.Dto;
using AbpVNextProject.Application.User.Dto;
using AbpVNextProject.Domain.UserInfo;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpVNextProject.Application
{
    public class AbpVNextProjectApplicationAutoMapperProfile: Profile
    {
        public AbpVNextProjectApplicationAutoMapperProfile()
        {
            CreateMap<Users, UserDto>();
            CreateMap<RoleInputDto, Roles>();
            CreateMap<Roles, RoleDto>();
        }
    }
}

using AbpVNextProject.Application.User;
using AbpVNextProject.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace AbpVNextProject.Application
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpVNextProjectEntityFrameworkCoreModule)
        )]
    public class AbpVNextProjectApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var services = context.Services;
            //services.AddSingleton<IUserAppService, UserAppService>();
            Configure<AbpAutoMapperOptions>(opt =>
            {
                opt.AddProfile<AbpVNextProjectApplicationAutoMapperProfile>();
            });
        }
    }
}

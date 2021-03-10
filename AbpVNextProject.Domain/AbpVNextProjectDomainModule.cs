using System;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpVNextProject.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule)
        )]
    public class AbpVNextProjectDomainModule:AbpModule
    {

    }
}

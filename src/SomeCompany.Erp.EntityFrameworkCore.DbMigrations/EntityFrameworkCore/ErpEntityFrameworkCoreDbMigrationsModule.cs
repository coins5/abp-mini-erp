﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SomeCompany.Erp.EntityFrameworkCore
{
    [DependsOn(
        typeof(ErpEntityFrameworkCoreModule)
        )]
    public class ErpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ErpMigrationsDbContext>();
        }
    }
}

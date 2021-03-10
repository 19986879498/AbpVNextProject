using AbpVNextProject.Domain.UserInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpVNextProject.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class AbpVNextProjectDbContext : AbpDbContext<AbpVNextProjectDbContext>
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }

        public AbpVNextProjectDbContext(DbContextOptions<AbpVNextProjectDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMSWebApi.Models;

namespace CMSWebApi.Data
{
    public class CMSWebApiDbContext : DbContext
    {
        public CMSWebApiDbContext (DbContextOptions<CMSWebApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<CMSWebApi.Models.Login> Login { get; set; }

        public DbSet<CMSWebApi.Models.Members> Members { get; set; }

        public DbSet<CMSWebApi.Models.Plans> Plans { get; set; }
    }
}

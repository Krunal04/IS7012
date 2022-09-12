using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatShigavkp.Models;

namespace RecruitCatShigavkp.Data
{
    public class RecruitCatShigavkpContext : DbContext
    {
        public RecruitCatShigavkpContext (DbContextOptions<RecruitCatShigavkpContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatShigavkp.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatShigavkp.Models.Company>? Company { get; set; }

        public DbSet<RecruitCatShigavkp.Models.Industry>? Industry { get; set; }

        public DbSet<RecruitCatShigavkp.Models.Jobtitle>? Jobtitle { get; set; }
    }
}

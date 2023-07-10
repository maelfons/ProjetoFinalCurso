using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalWEBMVC.Models
{
    public class ProjetoFinalWEBMVCContext : DbContext
    {
        public ProjetoFinalWEBMVCContext (DbContextOptions<ProjetoFinalWEBMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoFinalWEBMVC.Models.Department> Department { get; set; } = default!;
    }
}

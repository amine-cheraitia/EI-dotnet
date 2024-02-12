using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EI.Models;

namespace EI.Data
{
    public class EIContext : DbContext
    {
        public EIContext (DbContextOptions<EIContext> options)
            : base(options)
        {
        }

        public DbSet<EI.Models.Utilisateur> Utilisateur { get; set; } = default!;
    }
}

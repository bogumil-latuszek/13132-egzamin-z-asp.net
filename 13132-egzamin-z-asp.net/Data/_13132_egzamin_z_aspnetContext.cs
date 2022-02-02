using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _13132_egzamin_z_asp.net.Models;

namespace _13132_egzamin_z_asp.net.Data
{
    public class _13132_egzamin_z_aspnetContext : DbContext
    {
        public _13132_egzamin_z_aspnetContext (DbContextOptions<_13132_egzamin_z_aspnetContext> options)
            : base(options)
        {
        }

        public DbSet<_13132_egzamin_z_asp.net.Models.Awaria> Awaria { get; set; }
    }
}

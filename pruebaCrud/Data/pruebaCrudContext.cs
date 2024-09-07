using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pruebaCrud.Model;

namespace pruebaCrud.Data
{
    public class pruebaCrudContext : DbContext
    {
        public pruebaCrudContext (DbContextOptions<pruebaCrudContext> options)
            : base(options)
        {
        }

        public DbSet<pruebaCrud.Model.User> User { get; set; } = default!;
    }
}

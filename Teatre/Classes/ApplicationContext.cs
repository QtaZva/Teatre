using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}

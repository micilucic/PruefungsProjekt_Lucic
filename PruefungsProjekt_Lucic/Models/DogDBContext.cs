using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruefungsProjekt_Lucic.Models
{
    class DogDBContext:DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
    }
}

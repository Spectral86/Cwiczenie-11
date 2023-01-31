using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cwiczenie_11.Models;

namespace Cwiczenie_11.Data
{
    public class Cwiczenie_11Context : DbContext
    {
        public Cwiczenie_11Context (DbContextOptions<Cwiczenie_11Context> options)
            : base(options)
        {
        }

        public DbSet<Cwiczenie_11.Models.Movie> Movie { get; set; }
    }
}

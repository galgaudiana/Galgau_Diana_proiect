using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Galgau_Diana_proiect.Models;

namespace Galgau_Diana_proiect.Data
{
    public class Galgau_Diana_proiectContext : DbContext
    {
        public Galgau_Diana_proiectContext (DbContextOptions<Galgau_Diana_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<Galgau_Diana_proiect.Models.Car> Car { get; set; }
    }
}

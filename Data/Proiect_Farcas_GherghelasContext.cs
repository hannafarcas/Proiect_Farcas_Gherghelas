using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Farcas_Gherghelas.Models;

namespace Proiect_Farcas_Gherghelas.Data
{
    public class Proiect_Farcas_GherghelasContext : DbContext
    {
        public Proiect_Farcas_GherghelasContext (DbContextOptions<Proiect_Farcas_GherghelasContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Farcas_Gherghelas.Models.Partie> Partie { get; set; } = default!;

        public DbSet<Proiect_Farcas_Gherghelas.Models.Inchiriere>? Inchiriere { get; set; }

        public DbSet<Proiect_Farcas_Gherghelas.Models.Produs>? Produs { get; set; }

        public DbSet<Proiect_Farcas_Gherghelas.Models.Programare>? Programare { get; set; }

        public DbSet<Proiect_Farcas_Gherghelas.Models.User>? User { get; set; }
    }
}

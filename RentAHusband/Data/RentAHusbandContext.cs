using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentAHusband.Models;

namespace RentAHusband.Data
{
    public class RentAHusbandContext : DbContext
    {
        public RentAHusbandContext (DbContextOptions<RentAHusbandContext> options)
            : base(options)
        {
        }

        public DbSet<RentAHusband.Models.MaridoDeAluguel> MaridoDeAluguel { get; set; } = default!;
    }
}

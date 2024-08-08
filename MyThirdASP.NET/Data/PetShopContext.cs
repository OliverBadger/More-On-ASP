using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyThirdASP.NET.Models;

namespace MyThirdASP.NET.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext (DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public DbSet<MyThirdASP.NET.Models.Dog> Dog { get; set; } = default!;
    }
}

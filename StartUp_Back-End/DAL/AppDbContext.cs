using Microsoft.EntityFrameworkCore;
using StartUp_Back_End.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartUp_Back_End.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Autorh> Autorhs { get; set; }
    }
}

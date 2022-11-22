using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorDemo.Models;

namespace RazorDemo.Models
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Customer> CustomerTB { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Dbset = list of rows / table, here Items[0] represents first row
        public DbSet<Item> Items { get; set; }
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
    }
}

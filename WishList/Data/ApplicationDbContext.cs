using System;
using WishList.Models;
using Microsoft.EntityFrameworkCore;
namespace WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
    }
}

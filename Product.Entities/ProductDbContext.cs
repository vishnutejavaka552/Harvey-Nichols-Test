using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Entities
{
    public class ProductDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}

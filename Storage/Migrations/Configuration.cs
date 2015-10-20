using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using Storage.Models;
using System.ComponentModel.DataAnnotations;
using Storage.DataAccessLayer;

namespace Storage.Migrations {

    internal sealed class Configuration : DbMigrationsConfiguration<StorageContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StorageContext context) {
            context.Products.AddOrUpdate
            (p => p.Name,
                new Product { Name = "Product1", Price = 8.80m, Category = "Skit", Shelf = "1a", Count = 3, Description = "Product 1 a" },
                new Product { Name = "Product2", Price = 8.80m, Category = "Skit", Shelf = "2a", Count = 4, Description = "Product 1 a" },
                new Product { Name = "Product3", Price = 8.80m, Category = "Skit", Shelf = "3a", Count = 5, Description = "Product 1 a" },
                new Product { Name = "Product4", Price = 8.80m, Category = "Skit", Shelf = "4a", Count = 6, Description = "Product 1 a" },
                new Product { Name = "Product5", Price = 8.80m, Category = "Skit", Shelf = "5a", Count = 7, Description = "Product 1 a" },
                new Product { Name = "Product6", Price = 8.80m, Category = "Skit", Shelf = "6a", Count = 8, Description = "Product 1 a" }
            );
        }
    }
}


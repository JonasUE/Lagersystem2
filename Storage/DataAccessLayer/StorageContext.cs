using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Storage.DataAccessLayer;
using Storage;
namespace Storage.DataAccessLayer 
{
    public class StorageContext : DbContext 
    {
       public StorageContext()
        : base("DefaultConnection"){}
       public DbSet<Models.Product> Products { get; set; }

       public System.Data.Entity.DbSet<Storage.Models.CategorySelection> CategorySelections { get; set; }
    }
    
 }

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { 
        } 
         public DbSet<SubCategory> SubCategories { get; set; }
         public DbSet<MainProduct> MainProduct { get; set; }


    } 
            
 }
                
     
    


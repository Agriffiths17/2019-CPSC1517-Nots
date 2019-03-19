using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindModels;

namespace WestWindSystem.DAL
{

    internal class WestWindContext : DbContext
    {
        #region Constructors
        public WestWindContext() : base("name=Wwdb")
        {
            Database.SetInitializer<WestWindContext>(null);
        }
        #endregion

        #region Properties
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion
    }
}

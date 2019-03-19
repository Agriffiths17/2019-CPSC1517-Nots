using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindModels;
using WestWindSystem.DAL;

namespace WestWindSystem.BLL
{
    public class SupplierController
    {
        public List<Supplier> ListSuppliers()
        {
            using (var context = new WestWindContext())
            {
                return context.Suppliers.ToList();
            }
        }
    }
}

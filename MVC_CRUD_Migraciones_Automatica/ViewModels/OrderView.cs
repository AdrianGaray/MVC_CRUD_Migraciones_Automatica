using MVC_CRUD_Migraciones_Automatica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica.ViewModels
{
    public class OrderView
    {
        public Customer Customer { get; set; }
        public ProductOrder Product { get; set; }
        public List<ProductOrder> Products { get; set; }
    }
}
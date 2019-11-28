using Aspjquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspjquery.PartialModels
{
    public class PartialProductCostHistory
    {
        public int ProductID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public decimal StandardCost { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
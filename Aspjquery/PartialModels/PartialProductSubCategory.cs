using Aspjquery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspjquery.PartialModels
{
    public class PartialProductSubCategory
    {
        public int ProductSubcategoryID { get; set; }
        [Required(ErrorMessage ="Please select Product Category")]
        public int ProductCategoryID { get; set; }
        [Required(ErrorMessage = "*")]
        [Remote("CreateCategory", "ProductCategory", ErrorMessage = "Category already exists!")]
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual List<ProductCategory> ProductCategory { get; set; }
        public string CategoryName { get; set; }
        //public virtual ProductCategory ProductCategory { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
    }
}
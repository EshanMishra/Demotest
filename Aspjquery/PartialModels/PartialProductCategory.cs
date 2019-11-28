using Aspjquery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspjquery.PartialModels
{
    public class PartialProductCategory
    {
        public int ProductCategoryID { get; set; }
        [Required(ErrorMessage="*")]
        [Remote("CreateCategory", "ProductCategory", ErrorMessage = "Category already exists!")]
     //   [Remote("CreateCategory", "ProductCategory", ErrorMessage = "Category already exists!")]
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        //    public virtual ICollection<PartialProductSubCategory> ProductSubcategories { get; set; }
        //public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }

    }
}
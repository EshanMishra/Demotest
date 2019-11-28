using Aspjquery.PartialModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aspjquery.Models
{
    public partial class AdventureWorks2012Entities
    {
        public virtual DbSet<PartialProductCategory> PartialProductCategories { get; set; }
        public virtual DbSet<PartialProductSubCategory> PartialProductSubCategories { get; set; }
    }
}
using Aspjquery.Models;
using Aspjquery.PartialModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspjquery.Controllers
{
    public class ProductCategoryController : Controller
    {
        AdventureWorks2012Entities entities = new AdventureWorks2012Entities();
        //
        // GET: /ProductCategory/
        public ActionResult ProductCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(PartialProductCategory PartialCategory)
        {  Guid obj = Guid.NewGuid();  
            ProductCategory pc = new ProductCategory();
            if (ModelState.IsValid)
            {
                var data = entities.ProductCategories.Count(x=>x.Name==PartialCategory.Name);
             
                if (data > 0)
                {
                    ModelState.AddModelError("Name", "Category Name is already Exist");
                
                }
                else
                {
                    pc.Name = PartialCategory.Name;
                    pc.rowguid =(Guid) obj;
                    pc.ModifiedDate = DateTime.Now;
                    entities.ProductCategories.Add(pc);
            entities.SaveChanges();


                }
            }

            return View("ProductCategory");
        }
    
        public ActionResult ProductSubCategory()
        {
          
            PartialProductSubCategory listing = new PartialProductSubCategory();

            var list = entities.ProductCategories.ToList();
            listing.ProductCategory = list;
            //foreach (var a in list)
            //{

            //    listvalues.Add(new PartialProductSubCategory
            //    {
            //        CategoryName = a.Name,
            //        ProductCategoryID = a.ProductCategoryID
            //    });
            //}

            return View(listing);
        }
        [HttpPost]
        public ActionResult CreateSubCategory(PartialProductSubCategory PartialSubCategory)
        {
            Guid obj = Guid.NewGuid();
            ProductSubcategory pc = new ProductSubcategory();
            if (ModelState.IsValid)
            {
                var data = entities.ProductSubcategories.Count(x => x.Name == PartialSubCategory.Name);

                if (data > 0)
                {
                    ModelState.AddModelError("Name", "SubCategory Name is already Exist");
               //  return   ProductSubCategory();
                }
                else
                {
                    pc.Name = PartialSubCategory.Name;
                    pc.rowguid = (Guid)obj;
                    pc.ModifiedDate = DateTime.Now;
                    pc.ProductCategoryID = PartialSubCategory.ProductCategoryID;
                    entities.ProductSubcategories.Add(pc);
                    entities.SaveChanges();
                  

                }
            }
            ProductSubCategory();
            return View("ProductSubCategory");
        }

        }
}
using Aspjquery.Models;
using Aspjquery.PartialModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspjquery.Controllers
{
    public class ProductController : Controller
    {
        AdventureWorks2012Entities entities = new AdventureWorks2012Entities();
        // GET: Product
        public ActionResult Product()
        {
         
            PartialProduct listing = new PartialProduct();

            var list = entities.ProductSubcategories.ToList();
            listing.ProductSubcategoryList = list;
            return View(listing);
        }
      public ActionResult createProduct(PartialProduct pProduct)
        {
            Guid obj = Guid.NewGuid();
            Product pc = new Product();
            if (ModelState.IsValid)
            {
                var data = entities.Products.Count(x => x.Name == pProduct.Name);

                if (data > 0)
                {
                    ModelState.AddModelError("Name", "SubCategory Name is already Exist");
                    //  return   ProductSubCategory();
                }
                else
                {
                    pc.Name = pProduct.Name;
                    pc.rowguid = (Guid)obj;
                    pc.ModifiedDate = DateTime.Now;
                    pc.ProductNumber = pProduct.ProductNumber;
                    pc.MakeFlag = pProduct.MakeFlag;
                    pc.FinishedGoodsFlag = pProduct.FinishedGoodsFlag;
                    pc.SafetyStockLevel = pProduct.SafetyStockLevel;
                    pc.ReorderPoint = pProduct.ReorderPoint;
                    pc.StandardCost = pProduct.StandardCost;
                    pc.ListPrice = pProduct.ListPrice;
                    pc.DaysToManufacture = pProduct.DaysToManufacture;
                    pc.SellStartDate = DateTime.Now;
                    pc.ProductSubcategoryID = pProduct.ProductSubcategoryID;
                    entities.Products.Add(pc);
                    entities.SaveChanges();


                }
            }
            Product();
            return View("Product");

           
        }

        public ActionResult SetProductStandardCost()
        {
            PartialProductCostHistory listing = new PartialProductCostHistory();

            var list = entities.Products.ToList();
            listing.Product = list;
            return View(listing);
        }

        public ActionResult setStandartCost(PartialProductCostHistory partialproductcosthoistory)
        {
            ProductCostHistory pro = new ProductCostHistory();
            pro.ProductID = partialproductcosthoistory.ProductID;
            pro.StandardCost = partialproductcosthoistory.StandardCost;
            pro.StartDate = DateTime.Now;
            pro.EndDate = DateTime.Now.AddDays(30);
            pro.ModifiedDate = DateTime.Now;
            entities.ProductCostHistories.Add(pro);
            entities.SaveChanges();
            SetProductStandardCost();
            return View("SetProductStandardCost");
        }

    }
}
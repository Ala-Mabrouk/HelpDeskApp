using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppFunctions _AppFunctions = new AppFunctions();

        // GET: ProductsController
        public ActionResult Index()
        {
            List<Product> res = _AppFunctions.getListProducts().Result;
            ViewBag.listProducts = res;
            return View();
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(string id)
        {
                Product p= _AppFunctions.getProductById(id).Result;
                 ViewBag.product = p;
            /*     return View();*/

            
            return PartialView("Details");
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p1)
        {
            try
            {
               /* if (ModelState.IsValid)
                {*/
                   if(_AppFunctions.addProduct(p1).Result != null)
                    {
                        return RedirectToAction("Index","Products"); 
                    }
                return RedirectToAction("Erreur404", "Home");
                /*
                                }
                                return RedirectToAction("Create","Product");*/
            }
            catch
            {
                return RedirectToAction("Erreur404", "Home");
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(string id)
        {
          Product p=_AppFunctions.getProductById(id).Result;

               return PartialView("Edit",p); 
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            try
            {

               if( _AppFunctions.updateProduct(p).Result!= null)
                {
                    return RedirectToAction("Index", "Products");

                }

                return RedirectToAction("Erreur404", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(string id)
        {
            Product p = _AppFunctions.getProductById(id).Result;

            return PartialView("Delete", p);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product p)
        {
            try
            {
                if (_AppFunctions.DeleteProduct(p.refId).Result)
                {
                    return RedirectToAction("Index", "Products");

                }
                return RedirectToAction("Erreur404", "Home");

            }
            catch
            {
                return View();
            }
        }
    }
}

using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppFunctions _AppFunctions = new AppFunctions();

        // GET: ProductsController
        [Authorize]
        public ActionResult Index()
        {
            List<Product> res = _AppFunctions.getListProducts().Result;
            ViewBag.listProducts = res;
            return View();
        }


         
        [Authorize]
        public ActionResult Details(string id)
        {
                Product p= _AppFunctions.getProductById(id).Result;
                 ViewBag.product = p;
            /*     return View();*/

            
            return PartialView("Details");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [Authorize]
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
        [Authorize]

        public ActionResult Edit(string id)
        {
          Product p=_AppFunctions.getProductById(id).Result;

               return PartialView("Edit",p); 
        }

        [Authorize]
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

        [Authorize]
        public ActionResult Delete(string id)
        {
            Product p = _AppFunctions.getProductById(id).Result;

            return PartialView("Delete", p);
        }

        [Authorize]
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

        [HttpGet]
        public ActionResult ProductDisplay()
        {

            List<Product> res = _AppFunctions.getAllProducts();
            ViewBag.Products = res;
            return View();
        }
        [HttpGet]
        public ActionResult ProductDetail(string refId)
        {
            var res = _AppFunctions.getProductById(refId).Result;
            ViewBag.Product = res;
            return View();
        }
 

        [HttpGet]
        public ActionResult resultRech(string key)
        {


           ViewBag.result = _AppFunctions.findProduct(key).Result;


            return View();

        }



        public ActionResult buyProduct(string prodRef)
        {
            string res = User.FindFirstValue(ClaimTypes.Name).ToString();


          if(_AppFunctions.addProductClient(prodRef, res).Result)

            return RedirectToAction("ProductDispaly", "Product");



            return RedirectToAction("Erreur404", "Home");

        }


    }
}

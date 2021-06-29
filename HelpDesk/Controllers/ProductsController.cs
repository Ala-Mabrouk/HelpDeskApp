using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HelpDesk.Models;

namespace HelpDesk.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppFunctions _AppFunctions = new AppFunctions();
        private static string loged = "";



        // GET: ProductsController
        [Authorize]
        public ActionResult Index()
        {
            loged = User.FindFirstValue(ClaimTypes.Name).ToString();
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

            
            return PartialView("Details",p);
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
        public ActionResult Create([FromForm]Product p1)
        {
            try
            {

                var imgFile = p1.ImageFile;

                  
                string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                //To Get File Extension  
                string FileExtension = Path.GetExtension(imgFile.FileName);

                //Add Current Date To Attached File Name  
                FileName =FileName.Trim() + FileExtension;

                //Get Upload path from Web.Config file AppSettings.  
                string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\ProfileImges\\";

                //Its Create complete path to store in server.
                
                string completPath= UploadPath + FileName;
                p1.imgUrl = completPath;

                //save file in the uploadPath 

                using (var stream = new FileStream(completPath, FileMode.Create))
                {
                     imgFile.CopyTo(stream);

                }

                if (_AppFunctions.addProduct(p1).Result != null)
                {
                    return RedirectToAction("Index", "Products");
                }
                return RedirectToAction("Erreur404", "Home");
               
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

      [HttpGet]
        public IActionResult buyProduct(string prodRef)
        {
            var res = _AppFunctions.getProductById(prodRef).Result;
            ViewBag.product = res;

            if (res == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }

            return PartialView("buyProduct");
        }




        [Authorize]
        public ActionResult buyTheProduct(string pRef)
        {
            
            loged= User.FindFirstValue(ClaimTypes.Name).ToString();
            System.Diagnostics.Debug.WriteLine("my loged value: " + loged);
          if(_AppFunctions.addProductClient(pRef, loged).Result)

            return RedirectToAction("ProductDisplay", "Products");


            return RedirectToAction("Erreur404", "Home");

        }


    }
}

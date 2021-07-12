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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace HelpDesk.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppFunctions _AppFunctions = new AppFunctions();
        private static string loged = "";



        // GET: ProductsController
    
        [Authorize]
   
        public ActionResult Index(ResultOperation result )
        {
        
            loged = User.FindFirstValue(ClaimTypes.Name).ToString();
            List<Product> res = _AppFunctions.getListProducts().Result;
            ViewBag.listProducts = res;
            return View();
        }


        [Authorize]
        public ActionResult Details(string id)
        {
            Product p = _AppFunctions.getProductById(id).Result;
            return PartialView("Details", p);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.categories = new SelectList(_AppFunctions.getcategories().Result, "categoryId", "categoryName");
            return PartialView("Create");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Product p1)
        {
            try
            {
                if (p1.ImageFile != null)
                {
                    var imgFile = p1.ImageFile;


                    string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                    //To Get File Extension  
                    string FileExtension = Path.GetExtension(imgFile.FileName);

                    //Add Current Date To Attached File Name  
                    FileName = FileName.Trim() + FileExtension;

                    //Get Upload path from Web.Config file AppSettings.  
                    string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\ProfileImges\\";

                    //Its Create complete path to store in server.

                    string completPath = UploadPath + FileName;
                    p1.imgUrl = completPath;

                    //save file in the uploadPath 

                    using (var stream = new FileStream(completPath, FileMode.Create))
                    {
                        imgFile.CopyTo(stream);

                    }
                }
              

                     ResultOperation result = new ResultOperation();

                if (_AppFunctions.addProduct(p1).Result != null)
                {

                    result.statusOp = true;
                    result.message = "product added !";


                }
                else
                {
                    result.statusOp = false;
                    result.message = "can not add product for now !";
                }

                ViewBag.Message = result;
                List<Product> res = _AppFunctions.getListProducts().Result;
                ViewBag.listProducts = res;

                return View("Index");
            }
            catch
            {
                return RedirectToAction("Erreur404", "Home");
            }
        }


        [Authorize]

        public ActionResult Edit(string id)
        {
            Product p = _AppFunctions.getProductById(id).Result;
            ViewBag.categories = new SelectList(_AppFunctions.getcategories().Result, "categoryId", "categoryName");


            return PartialView("Edit", p);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            try
            {
                if (p.ImageFile != null)
                {
                    var imgFile = p.ImageFile;


                    string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                    //To Get File Extension  
                    string FileExtension = Path.GetExtension(imgFile.FileName);

                    //Add Current Date To Attached File Name  
                    FileName = FileName.Trim() + FileExtension;

                    //Get Upload path from Web.Config file AppSettings.  
                    string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\ProfileImges\\";

                    //Its Create complete path to store in server.

                    string completPath = UploadPath + FileName;
                    p.imgUrl = completPath;

                    //save file in the uploadPath 

                    using (var stream = new FileStream(completPath, FileMode.Create))
                    {
                        imgFile.CopyTo(stream);

                    }
                }
                ResultOperation result = new ResultOperation();

                if (_AppFunctions.updateProduct(p).Result != null)
                {

                    result.statusOp = true;
                    result.message = "product updated !";


                }
                else
                {
                    result.statusOp = false;
                    result.message = "product not updated !";
                }

                ViewBag.Message = result;
                List<Product> res = _AppFunctions.getListProducts().Result;
                ViewBag.listProducts = res;

                return View("Index");
            }
            catch
            {
                return RedirectToAction("Erreur404", "Home");
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
                
                ResultOperation result = new ResultOperation();

                if (_AppFunctions.DeleteProduct(p.refId).Result)
                {

                    result.statusOp = true;
                    result.message = "product deleted !";


                }
                else
                {
                    result.statusOp = false;
                    result.message = "Can not delete product for now !";
                }

                ViewBag.Message = result;
                List<Product> res = _AppFunctions.getListProducts().Result;
                ViewBag.listProducts = res;

                return View("Index");


            }
            catch
            {
                return RedirectToAction("Erreur404", "Home");
            }
        }

        [HttpGet]
        public ActionResult ProductDisplay()
        {

            List<Product> res = _AppFunctions.getAllProducts();

            ViewBag.Categories = _AppFunctions.getcategories().Result;

            return View(res);
        }

        [HttpGet]
        public ActionResult ProductDetail(string refId)
        {
            var res = _AppFunctions.getProductById(refId).Result;
         
            return View(res);
        }


        [HttpGet]
        public ActionResult resultRech(string key)
        {


         var listProducts= _AppFunctions.findProduct(key).Result;


            return View(listProducts);

        }


        [Authorize]
        [HttpGet]
        public IActionResult buyProduct(string prodRef)
        {
            var res = _AppFunctions.getProductById(prodRef).Result;
            ViewBag.product = res;

            if (res == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }

            return View();
        }




        [Authorize]
        [HttpPost]
        public ActionResult buyProduct(PaymentCard p)
        {

            loged = User.FindFirstValue(ClaimTypes.Name).ToString();

            string pId = Request.Form["productRefId"];

            var res = _AppFunctions.getProductById(pId).Result;
            ViewBag.product = res;


            if (ModelState.IsValid)
            {
                string cardnb = p.cardNumber.Replace(" ", "");



                Regex expression = new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");




                if (expression.IsMatch(cardnb))
                {

                    System.Diagnostics.Debug.WriteLine("pattern succedd");
                    if (_AppFunctions.addProductClient(pId, loged).Result)

                        return RedirectToAction("ProductDisplay", "Products");

                }
                ModelState.AddModelError("", "card number invalid");


            }



            return PartialView("buyProduct", p);

        }


        public IActionResult buyTheProduct(string pRef)
        {
            loged = User.FindFirstValue(ClaimTypes.Name).ToString();
            if (_AppFunctions.addProductClient(pRef, loged).Result)

                return RedirectToAction("ProductDisplay", "Products");

            else

                return RedirectToAction("Erreur404", "Home");
        }


    }
}

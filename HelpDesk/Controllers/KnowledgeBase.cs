using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{

    public class KnowledgeBase : Controller
    {


        private readonly AppFunctions _AppFunctions = new AppFunctions();
        public IActionResult Index()
        {
            ViewBag.Categories = _AppFunctions.getListCategories().Result;


            return View();
        }



        public IActionResult singleArticleInfo(int articleId)
        {
            Article a = _AppFunctions.getArticleInfo(articleId).Result;
             

            return View(a);
        }



        public IActionResult singleArticleCategory(string category)
        {
            var res = _AppFunctions.getListAllArticlesByCategory(category).Result;
            ViewBag.ListArticles = res;
            ViewBag.category = category;
            return View();
        }

        [HttpGet]
        public IActionResult addArticle()
        {
            ViewBag.ArticlesCategories = new SelectList(_AppFunctions.getcategories().Result, "categoryId", "categoryName");
            return View();
        }

        [HttpPost]
        public IActionResult addArticle(Article ar)
        {
            int id = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;
            ar.creator_agentId = id;
            ar.creationDate = DateTime.Now;
            ar.lastModified = DateTime.Now;

            ResultOperation result = new ResultOperation();

            if (_AppFunctions.addArticle(ar).Result)
            {

                result.statusOp = true;
                result.message = "article adeded !";


            }
            else
            {
                result.statusOp = false;
                result.message = "Can not add article for now !";
            }

            ViewBag.Message = result;
            ViewBag.Articles = _AppFunctions.getAllArticles().Result;

            return View("listArticles");
 
        }

        public IActionResult listArticles()
        {
            ViewBag.Articles = _AppFunctions.getAllArticles().Result;
            ViewBag.Categories = _AppFunctions.getcategories().Result;
            return View();
        }

        public IActionResult infoArticle(int idArticle)
        {
            var article = _AppFunctions.getArticleInfo(idArticle).Result;

            return PartialView("infoArticle", article);
        }


        public IActionResult deleteArticle(int articleId)
        {

            var res = _AppFunctions.getArticleInfo(articleId).Result;
            return PartialView("deleteArticle", res);
        }

        public IActionResult delete()
        {
            int idArticle = Int16.Parse(Request.Form["ArticleId"]);
          
            ResultOperation result = new ResultOperation();

            if (_AppFunctions.removeArticle(idArticle).Result)
            {

                result.statusOp = true;
                result.message = "article is deleted!";


            }
            else
            {
                result.statusOp = false;
                result.message = "Can not delete article for now !";
            }

            ViewBag.Message = result;
            ViewBag.Articles = _AppFunctions.getAllArticles().Result;

            return View("listArticles");
 
        }

        [HttpGet]
        public IActionResult updateArticle(int Id)
        {
            ViewBag.ArticlesCategories = new SelectList(_AppFunctions.getcategories().Result, "categoryId", "categoryName");

            Article a = _AppFunctions.getArticleInfo(Id).Result;

            return PartialView("updateArticle", a);
        }

        [HttpPost]
        public IActionResult updateArticle(Article a)
        {
            try
            {
                int id = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;
                a.creator_agentId = id;
                a.lastModified = DateTime.Now;

                ResultOperation result = new ResultOperation();

                if (_AppFunctions.updateArticle(a).Result != null)
                {

                    result.statusOp = true;
                    result.message = "article is updated!";


                }
                else
                {
                    result.statusOp = false;
                    result.message = "Can not update article for now !";
                }

                ViewBag.Message = result;
                ViewBag.Articles = _AppFunctions.getAllArticles().Result;

                return View("listArticles");







            }
            catch (Exception e)
            {

                return RedirectToAction("Erreur404", "Home");
            }
            return RedirectToAction("Erreur404", "Home");

        }


    }
}

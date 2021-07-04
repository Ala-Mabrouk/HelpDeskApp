using AppFeatures;
using Entities.Entities;
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
            ViewBag.theArticle = a;

            return View();
        }



        public IActionResult singleArticleCategory(string category)
        {
            var res = _AppFunctions.getListAllArticlesByCategory(category).Result;
            ViewBag.ListArticles = res;
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
            if (_AppFunctions.addArticle(ar).Result)
            {

                return RedirectToAction("listArticles");
            }
            return View();
        }

        public IActionResult listArticles()
        {
            ViewBag.Articles = _AppFunctions.getAllArticles().Result;
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
            if (_AppFunctions.removeArticle(idArticle).Result)
            {
                return RedirectToAction("listArticles", "KnowledgeBase");
            }
            return RedirectToAction("listArticles", "KnowledgeBase");
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
                if (_AppFunctions.updateArticle(a).Result != null)
                    return RedirectToAction("listArticles","KnowledgeBase");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("**********" + e);
                return RedirectToAction("Erreur404", "Home");
            }
            return RedirectToAction("Erreur404", "Home");

        }


    }
}

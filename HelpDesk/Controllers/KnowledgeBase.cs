using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

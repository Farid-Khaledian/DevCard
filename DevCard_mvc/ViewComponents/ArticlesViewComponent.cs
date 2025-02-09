using System.Collections.Generic;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_mvc.ViewComponents
{
    public class ArticlesViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Article> articles = new List<Article>() {
            new Article(1,"Article1 " ,"blog-post-thumb-card-1.jpg", "About our hoem"),
            new Article(2 ,"Article2" ,"blog-post-thumb-card-2.jpg", "About our work in ofice"),
            new Article(3 , "Article 3","blog-post-thumb-card-3.jpg" , "About how to selse")

            };


            return View("_AArticless.cshtml" , articles );
        }

    }
}

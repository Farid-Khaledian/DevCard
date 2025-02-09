using System.Collections.Generic;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_mvc.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            List<Project> projects = new List<Project>() {
            new Project(1,"تاکسی " ,"project-1.jpg" , "درخواست انلاین تاکس "  ," atria"),
            new Project(2,"زودفود ","project-2.jpg" , "درخواست انلاین غذا" , " snapfood"),
            new Project(3," مدارس","project-3.jpg" , "درخواست انلاین سرویس" , "monop "),
            new Project(4,"فضاپیما " ,"project-4.jpg", "درخواست انلاین فضاپیما" , "nasa")

            };

         
            return View("_PProjectss.cshtml" , projects);

        }

    }
}

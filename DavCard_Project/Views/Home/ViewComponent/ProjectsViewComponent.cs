using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DavCard_MVC.Models;

namespace DavCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
        
    {

        public IViewComponentResult Invoke(string name)
        {
            var Projects = new List<Project>
            {
                new Project(id:1 , name:"تاکسی" , description:"درخواست انلاین تاکسی برای سفرهای درون شهری", image:"project-1.jpg" ,client:"Snap" ),
                new Project(id:2 , name:"زودفود" , description:"درخواست انلاین غذا برای سرار کشور", image:"project-2.jpg" ,client:"ZoodFood" ),
                new Project(id:3 , name:"مدارس" , description:"سیستم مدیریت یکپارچه مدارس", image:"project-3.jpg" ,client:"Monop" ),
                new Project(id:4 , name:"فضاپیما" , description:"برنامه مدیریت فضاپیما های ناسا", image:"project-4.jpg" ,client:"Nasa" )

            };
         return View("_Projects" , Projects);
        }



    }
}

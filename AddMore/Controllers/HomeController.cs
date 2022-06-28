using AddMore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AddMore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MainView()
        {
            return View(); //this is main page.We will display  "_AddMorePartialView" partial page on this main page
        }
        public ActionResult AddMorePartialView()
        {
            //this  action page is support cal the partial page.
            //We will call this action by view page.This Action is return partial page
            AddMoreViewModel model = new AddMoreViewModel();
            return PartialView("_AddMorePartialView", model);
            //^this is actual partical page we have 
            //create on this page in Home Controller as given below image
        }
        public ActionResult PostAddMore(AddMoreViewModel model)
        {
            //Here,Post addmore value from view page and get multiple values from view page
            return View();
        }
    }
}
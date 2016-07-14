//using GoogleMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Residential_capstone_project.Controllers
{
    public class MapsController : Controller
    {

        // GET: Map
        //public ActionResult Index()
        //{
        //    GoogleMapEntities GE = new GoogleMapEntities();
        //    return View(GE.Locations.ToList());
        //}

        //[HttpPost]
        //public ActionResult Search(string Location)
        //{
        //    GoogleMapEntities GE = new GoogleMapEntities();
        //    var result = GE.Locations.Where(x => x.LocationName.StartsWith(Location)).ToList();
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
        
        public ActionResult GroupMap()
        {

            return View();
        }

        public ActionResult PersonalMap()
        {

            return View();
        }

        public ActionResult LandlordMap()
        {
            return View();
        }

        public ActionResult EditPersonalMap()
        {
            return View();

        }


        public ActionResult Index()
        {
            return View();
        }

    }
}
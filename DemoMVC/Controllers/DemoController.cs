
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(int id)
        {
            AutoModel autoModel = new AutoModel();
            autoModel.KilometerStand = 150000;
            autoModel.Merk = "Toyota";
            autoModel.Type = "Auris";

            AutoModel autoModel2 = new AutoModel();
            autoModel2.KilometerStand = 20;
            autoModel2.Merk = "BMW";
            autoModel2.Type = "109D";

            List<AutoModel> autolijst = new List<AutoModel>();
            autolijst.Add(autoModel2);
            autolijst.Add(autoModel);

            return View(autolijst);
        }
    }
}


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
            FietsModel fietsModel = new FietsModel();
            fietsModel.Maat = 150000;
            fietsModel.Merk = "Toyota";
            fietsModel.Type = "Auris";

            FietsModel fietsModel2 = new FietsModel();
            fietsModel2.Maat = 20;
            fietsModel2.Merk = "BMW";
            fietsModel2.Type = "109D";

            List<FietsModel> fietslijst = new List<FietsModel>();
            fietslijst.Add(fietsModel2);
            fietslijst.Add(fietsModel);

            return View(fietslijst);
        }
    }
}

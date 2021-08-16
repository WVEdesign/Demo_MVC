using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class ProductsController : Controller
    {
        List<FietsModel> fietslijst = new List<FietsModel>();
        public ProductsController()
        {
            FietsModel fietsModel1 = new FietsModel();
            fietsModel1.Id = 1;
            fietsModel1.Naam = "WervelwindI";
            fietsModel1.Prijs = decimal.Parse("1199,99");
            fietsModel1.Maat = 28;
            fietsModel1.Merk = "Trek";
            fietsModel1.Type = "MTB";
            fietsModel1.Foto = "images/bikes/koers-team-bikes-1.jpg";

            FietsModel fietsModel2 = new FietsModel();
            fietsModel2.Id = 2;
            fietsModel2.Naam = "WervelwindII";
            fietsModel2.Prijs = decimal.Parse("899,99"); 
            fietsModel2.Maat = 26;
            fietsModel2.Merk = "Giant";
            fietsModel2.Type = "Koersvello";
            fietsModel2.Foto = "images/bikes/koers-team-bikes-2.jpg";

            FietsModel fietsModel3 = new FietsModel();
            fietsModel3.Id = 3;
            fietsModel3.Naam = "Grinder";
            fietsModel3.Prijs = 1599.99M; 
            fietsModel3.Maat = 28;
            fietsModel3.Merk = "Giant";
            fietsModel3.Type = "MTB";
            fietsModel3.Foto = "images/bikes/koers-team-bikes-3.jpg";

            FietsModel fietsModel4 = new FietsModel();
            fietsModel4.Id = 4;
            fietsModel4.Naam = "FlyOver";
            fietsModel4.Prijs = decimal.Parse("2499,99"); 
            fietsModel4.Maat = 28;
            fietsModel4.Merk = "Trek";
            fietsModel4.Type = "MTB";
            fietsModel4.Foto = "images/bikes/mountain-team-bikes-1.jpg";

            
            fietslijst.Add(fietsModel1);
            fietslijst.Add(fietsModel2);
            fietslijst.Add(fietsModel3);
            fietslijst.Add(fietsModel4);

        }
        public IActionResult Index(int id)
        {
            return View(fietslijst);
        }
        public IActionResult Detail(int id)
        {
            return View(fietslijst[id-1]);
        }
    }
}

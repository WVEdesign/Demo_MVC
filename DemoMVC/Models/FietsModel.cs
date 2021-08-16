using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class FietsModel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public int Maat { get; set; }
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Foto { get; set; }

    }
}

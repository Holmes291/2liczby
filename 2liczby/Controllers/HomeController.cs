using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2liczby.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
   
        [HttpPost]
        public ViewResult Index(Models.MLicz dane)
        {
            bool x1, x2;
            double c1, c2;
            x1 = double.TryParse(dane.liczba1, out c1);
            x2 = double.TryParse(dane.liczba2, out c2);

            if (x1 == true && x2 == true)
            {
                c1 = Convert.ToDouble(dane.liczba1);
                c2 = Convert.ToDouble(dane.liczba2);
                dane.dziaba = 0;
                if (dane.coMaByc == "suma") dane.wynik = c1 + c2;
                if (dane.coMaByc == "roznica") dane.wynik = c1 - c2;
                if (dane.coMaByc == "iloczyn") dane.wynik = c1 * c2;
                if (dane.coMaByc == "iloraz")
                {
                    if (c2 == 0) dane.dziaba = 2;
                    else dane.wynik = c1 / c2;
                }
            }
            else dane.dziaba = 1;
            
            return View(dane);
        }
        
    }
}
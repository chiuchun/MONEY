using MONEY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MONEY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            money db = new money();
            Random rnd = new Random();//亂數種子
            //for (int i = 0; i < 1000; i++)
            //{
            //    pegeData.number = rnd.Next(0, 100);
            //}
            var listmoney = new List<MyClass>();
            var type = "";
            foreach (var i in db.AccountBook)
            {
                if (i.Categoryyy == 0) { type = "支出"; } else { type = "收入"; }

                listmoney.Add(new MyClass
                {
                    ID = i.Id.ToString(),
                    CLASS11 = type,
                    DT = i.Dateee,
                    MONEY = i.Amounttt,
                    ABOUT = i.Remarkkk

                });


            }
            return View(listmoney);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}
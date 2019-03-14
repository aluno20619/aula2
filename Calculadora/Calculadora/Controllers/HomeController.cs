using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Ecra = 0;
            //vars aux
            Session["primeiraVezOperador"] == true;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string bt, string visor) {
            string ecra = visor;
            //identifaicar o valor na variavel bt
            switch (bt) {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    // se entrei aqui, é porque foi selecionado um algorismo
                    //decidir o que fazer se so existir zero
                
                    if (visor =="0") {//outra opçao seria visor.equals(0) 
                        ecra = bt;
                    }
                    else//esta operaçao concatena as strings
                        ecra = ecra + bt;
                    break;
                case ",":
                    if (!visor.Contains(",")) ecra = ecra + bt;

                    break;
                case "+":
                case "-":
                case "*":
                case ":":
                    //é a 1º vez que se carrega no operador
                    if ((bool)Session["primeiraVezOperador"] == true) {

                    }
                    break;
            }

            ViewBag.Ecra = ecra;

            return View();
        }
    }
}
using System.Web.Mvc;

namespace AntiXssTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult XssTest()
        {
            return View();
        }
        public ActionResult XssTest1()
        {
            return View();
        }

        public ActionResult XssTest2()
        {
            return View();
        }
        public ActionResult XssTest3()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] // 允許 HTML 輸入
        public ActionResult XssTest(string userInput)
        {
            ViewData["rawData"] = userInput;  // 傳遞未過濾的原始輸入
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] // 允許 HTML 輸入
        public ActionResult XssTest1(string userInput)
        {
            ViewData["rawData1"] = userInput;  // 傳遞未過濾的原始輸入
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] // 允許 HTML 輸入
        public ActionResult XssTest2(string userInput)
        {
            ViewData["rawData2"] = userInput;  // 傳遞未過濾的原始輸入
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] // 允許 HTML 輸入
        public ActionResult XssTest3(string userInput)
        {
            ViewData["rawData3"] = userInput;  // 傳遞未過濾的原始輸入
            return View();
        }
    }
}
using System.Web.Mvc;

namespace ObserverClient.Controllers
{
    public class IndicatorsController : Controller
    {
        // GET: All Indicators
        public ActionResult Index()
        {
            return View();
        }

        // GET: Temperature
        public ActionResult Temperature()
        {
            return View();
        } 
        
        // GET: Humidity
        public ActionResult Humidity()
        {
            return View();
        }
    }
}
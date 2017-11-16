using System.Linq;
using System.Web.Mvc;
using YourResume.Models;

namespace YourResume.Controllers
{
    public class HomeController : Controller
    {
        YourResumeEntities db = new YourResumeEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDocumentFileName()
        {
            return Json(new
            {
                document = db.tblDocuments.FirstOrDefault().Name
            }, 
            JsonRequestBehavior.AllowGet);
        }
    }
}
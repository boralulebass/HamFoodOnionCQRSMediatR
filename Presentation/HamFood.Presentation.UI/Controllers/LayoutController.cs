using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.Controllers
{
    public class LayoutController : Controller
    {
        public PartialViewResult Head()
        {
            return PartialView();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }

       

        public PartialViewResult Footer()
        {
            return PartialView();
        }
        public PartialViewResult Scripts()
        {
            return PartialView();
        }



    }
}

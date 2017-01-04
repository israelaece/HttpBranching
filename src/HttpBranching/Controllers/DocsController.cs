using Microsoft.AspNetCore.Mvc;

namespace HttpBranching.Controllers
{
    [Route("[controller]")]
    public class DocsController : Controller
    {
        public ActionResult Index() => View();
    }
}
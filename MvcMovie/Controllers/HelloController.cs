using System.Web;
using System.Web.Mvc;
namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // GET: /Hello/
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        //// GET: /Hello/Welcome/
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        // GET: /Hello/Welcome/
        [Route("WelcomeYou/{name}/{numTimes:int}")]
        public string Welcome(string name, int id)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + id);
        }

    }
}
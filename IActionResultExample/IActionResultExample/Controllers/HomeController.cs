using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("book")]
        public IActionResult Index()
        {
            //id should be supplied
            if (!Request.Query.ContainsKey("id"))
            {
                
                return BadRequest("id is not supplied");
            }

            //id can't be empty
            if (String.IsNullOrEmpty(Convert.ToString(Request.Query["id"])))
            {
               
                return BadRequest("id should not be null or empty");
            }

            int id = Convert.ToInt32(Request.Query["id"]);

            if (id < 1 || id > 1000)
            {
                
                return BadRequest("id should in between 1 to 1000");
            }

            bool isAuth = Convert.ToBoolean(Request.Query["isAuth"]);

            if (!isAuth)
            {
             
                return Unauthorized("user is unAuthorized");
            }

            return RedirectToActionPermanent("Index","Store",new {});



        }
    }
}

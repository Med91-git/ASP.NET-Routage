using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Routage.Controllers
{
    public class HelloController : Controller
    {
        [Route("/Say")] 
        public String SayHello()
        {
            return "Hello !";
        }
        [Route("/Yell")]
        public String YellHello()
        {
            return "HELLO !";  
        }
    }
}

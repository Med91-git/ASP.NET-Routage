using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Routage.Controllers
{
    
    public class HelloController : Controller
    {
        public String SayHello()  
        {
            return "Hello !";
        }

        public String YellHello()
        {
            return "HELLO !";  
        }

        [Route("/{controller}/SayAttribute")]    
        public String SayHelloAttribute()
        {
            return SayHello();
        }

        [Route("/{controller}/YellAttribute")] 
        public String YellHelloAttribute() 
        {
            return YellHello();  
        }
    }
}

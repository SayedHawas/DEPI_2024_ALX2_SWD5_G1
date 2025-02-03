using Microsoft.AspNetCore.Mvc;

namespace WebApiCRUDDay3Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> names = new List<string> { "Sayed", "Ahmed", "Ali", "Zayed" };
        //Http://www.localhost:5276/api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return names;
        }
        //[HttpGet]
        //Routing 
        //Http://www.localhost:5276/api/Values
        //Web Api (Method RUN Over HTTP request ) 
        //Http 
        //WWW
        //(Server IIS --> Proxy server --> DLL -->Class(Controller) --> Method)
        //localhost Domain   Google.com  128.25.55.10
        //:5276  Port  Door
        // api
        // Class Name Type Of Controller Values 
        //vebr Http Get  

        //Http://www.localhost:5276/api/Values/2
        // 2 : route Value For ID 
        //[HttpGet("{id}")]
        //public string GetById(int id)
        //{
        //    return names[id];
        //}
        //Naming convention
        //Http://www.localhost:5276/api/Values/2
        [HttpGet("{num}")]
        public string GetId(int num)
        {
            return names[num];
        }

    }
}

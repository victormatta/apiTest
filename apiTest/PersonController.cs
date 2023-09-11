using Microsoft.AspNetCore.Mvc;

namespace apiTest
{
        [Route("api/[controller]")]
        [ApiController]
        public class PersonController : ControllerBase
        {
            [HttpGet]
            public ActionResult<Person> Get()
            {
                var person = new Person
                {
                    Name = "Victor",
                    Description = "Victor is a Software Developer and he uses some programming languages such as C#, JavaScript (node), php and flutter"
                };

                return person;
            }
        }
    
}

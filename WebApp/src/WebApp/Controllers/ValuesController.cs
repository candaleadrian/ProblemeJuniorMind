using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApp.Controllers
{
  //  [Route("api/[controller]")]
    [Route("mainpage.html/[controller]")]
    public class ValuesController : Controller
    {

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
         
        // GET api/values/5
        [HttpGet("{id}/{id2}")]
        public string Get(int id, int id2)
        {
            
            pasword.PasswordOptions tmp = new pasword.PasswordOptions(8,1,1,1,true,true);
            return pasword.GeneratePassword(tmp);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

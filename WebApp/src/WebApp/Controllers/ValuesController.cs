using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
         
        // GET api/values/5
        [HttpGet("{length}/{upp}/{nr}/{symb}/{sim}")]
        public string Get(int length,int upp, int nr, int symb, int sim)
        {
            bool simBool = false;
            if (sim != 0)
                simBool = true;

            Pasword.PasswordOptions tmp = new Pasword.PasswordOptions(length, upp, nr, symb,simBool,true);
            return Pasword.GeneratePassword(tmp);
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

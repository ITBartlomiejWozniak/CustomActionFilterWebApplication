using CustomActionFilterWebApplication.Filters;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CustomActionFilterWebApplication.Controllers
{
    [CustomFilter]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5

        [CustomExceptionFilter]
        public string Get(int id)
        {
            if (id < 0)
                throw new Exception("Can't be negative number.");
            return "value";
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

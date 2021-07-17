using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {

        //Created static list of type string to test api - GET, PUT, POST and DELETE operations
        //Represent strongly typed list of object that can be access by index.
        //And also give methods such as Sort, search, manipulations list. 
        static List<string> strings = new List<string>()
        {

            "value0","value1", "value2"

        };


        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return strings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return strings[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            strings.Add(value); //crete a new record in stings

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            strings[id] = value; //will update value of strings at id 
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id); //this will remove value from static list stings at particular id
        }
    }
}

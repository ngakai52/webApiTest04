using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest04.Controller
{
    [RoutePrefix("api/hello2")]
    public class HelloController : ApiController
    {
        //the two mwthod, Get and Get2, both work.
        //Method Get2 is a Put request( /api/hello2/live )

        [HttpPut]
        [Route("live")]
        //[HttpPut]
        public string Get()
        {
            return "Hello World";
        }

        //public string Get()
        //{
        //    return "this is a simple get";
        //}

        public string Post()
        {
            return "this is a post";
        }
        
    }
}
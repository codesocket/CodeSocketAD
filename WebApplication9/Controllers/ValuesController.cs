﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication9.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            Trace.TraceError("Error: If you're seeing this, something bad happened");
            Trace.TraceWarning("Warning: If you're seeing this, something bad happened");
            Trace.TraceInformation("Information: If you're seeing this, something bad happened");
            Trace.Write("Verbose: This is verbose logging");

            return Ok(User.Identity.Name);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

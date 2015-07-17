using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace formIOTest.Controllers
{
    [RoutePrefix("api/FormIO")]
    public class FormIOController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult getStuff(HttpRequestMessage request)
        {
            // read the request content
            StreamReader sr = new StreamReader(request.Content.ReadAsStreamAsync().Result);
            String requestString = sr.ReadToEnd();

            // Find out the basic authentication getting passed
            byte[] data = Convert.FromBase64String(request.Headers.Authorization.Parameter);

            // this will be the decoded string frmo the basic authorization.  You can then do whatever you want
            string decodedString = Encoding.UTF8.GetString(data);


            // lets pass back a success (200) to the calling client
            return Ok();
        }

    }
}

# RESTTools
This is a simple MVC WebAPI tool that allows you to quickly test RESTful webhooks.  I wrote this to do a quick test from Form.io to read what they were posting back after I did an update.

The guts of the code is in the Controllers.FormIOController.  You can see below the code that receives an HTTPRequestMessage, reads it as a string, and looks at your authorization.

NOTE:  this code does NOT do any authentication.  You can wire that up yourself.  I just needed a quick and dirty tool to read incoming payloads from Form.io.


The way you would be able to call this is via the following path:

    http://serverName:portID/api/formIO

The method will then read the HttpRequestMessage and convert it to a string.

Another NOTE:  I am using IIS Express in this, so it isnt accessible to something outside of localhost.  If you want to debug, run this as Local IIS or install it on a server (or Azure) where you can remote debug.

I am also not doing anything with the data I am receiving.  You can always deserialize to an object (using newtonsoft json) or save to a file or whatever you want. 



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

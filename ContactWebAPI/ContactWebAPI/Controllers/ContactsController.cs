using ContactsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactsList.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return new Contact[]{
                new Contact { Id = 1, EmailAddress = "airjordan@contoso.com", Name = "Michael Jordan"},
                new Contact { Id = 2, EmailAddress = "brianredmond@contoso.com", Name = "Brian Redmond"},
                new Contact { Id = 3, EmailAddress = "bird@contoso.com", Name = "Larry Bird"},
                new Contact { Id = 4, EmailAddress = "lebron@contoso.com", Name = "LeBron James"}
            };
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] Contact contact)
        {
            // todo: save the contact somewhere
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
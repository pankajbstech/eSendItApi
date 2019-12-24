using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eSendItDataAccess;
namespace eSendItApi.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            using (eSendItEntities dbconetx = new eSendItEntities())
            {
                return dbconetx.Users.ToList();
            }
        }
        public User Get(int id)
        {
            using (eSendItEntities dbconetx = new eSendItEntities())
            {
                return dbconetx.Users.FirstOrDefault(x => x.UserId == id);
            }
        }
        public HttpResponseMessage Post([FromBody] User u)
        {
            try
            {
                using (eSendItEntities dbcontext = new eSendItEntities())
                {
                    dbcontext.Users.Add(u);
                    dbcontext.SaveChanges();
                    var msg = Request.CreateResponse(HttpStatusCode.Created, u);
                    msg.Headers.Location = new Uri(Request.RequestUri + u.UserId.ToString());
                    return msg;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}

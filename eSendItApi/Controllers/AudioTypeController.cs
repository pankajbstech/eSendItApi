using eSendItDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eSendItApi.Controllers
{
    public class AudioTypeController : ApiController
    {
        public IEnumerable<AudioType> Get()
        {
            using (eSendItEntities dbcontext = new eSendItEntities())
            {
                return dbcontext.AudioTypes.ToList();
            }
        }
        public AudioType Get(int id)
        {
            using (eSendItEntities dbcontext = new eSendItEntities())
            {
                return dbcontext.AudioTypes.FirstOrDefault(x => x.AudioTypeId == id);
            }
        }
    }
}

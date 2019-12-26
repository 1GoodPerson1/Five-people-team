using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EF;

namespace WebApi.Controllers
{
    public class GirlController : ApiController
    {
        [HttpGet]
        public object get()
        {
            var data = new { Data = UserDal.selgirl() };
            return data;
        }
    }
}

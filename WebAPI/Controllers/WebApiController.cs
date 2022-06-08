using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class WebApiController : ApiController
    {
        ProductsDbEntities db = new ProductsDbEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetData()
        {
            List<Category> list = db.Categories.ToList();
            return Ok(list);
        }
    }
}

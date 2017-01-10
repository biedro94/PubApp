using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DependencyResolver;
using Data.Model;

namespace WebService.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        [HttpPost]
        public DMLResult CreateOrder(int Client_Id, int Table_Number, int ProductsList_I)
        {
            DMLResult exam = new DMLResult();
            Result<DMLResult> cexam = DependencyResolver.DependencyResolver.Get().CreateOrderService(Client_Id, Table_Number, ProductsList_I);
            if (cexam.Success)
            {
                exam = cexam.Data;
                return exam;
            }
            else
                return null;
            
        }
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}

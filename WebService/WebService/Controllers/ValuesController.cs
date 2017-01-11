using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DependencyResolver;
using Data.Model;
using Newtonsoft.Json;

namespace WebService.Controllers
{

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

        [HttpPost]
        [Route("User/Registration/{Client_Email}/{Client_Password}")]
        public DMLResult RegisterUser(string Client_Email, string Client_Password)
        {
            DMLResult res = new DMLResult();
            Result<DMLResult> cres = DependencyResolver.DependencyResolver.Get().RegisterUserService(Client_Email, Client_Password);
            if (cres.Success)
            {
                res = cres.Data;
                return res;
            }
            else
                return null;

        }

        [HttpGet]
        [Route("Product/List")]
        public List<Product> GetListOfProducts()
        {
            List<Product> result = new List<Product>();
            Result<List<Product>> res = DependencyResolver.DependencyResolver.Get().GetListOfProductsService();
            if (res.Success)
            {
                foreach(Product pr in res.Data)                
                    result.Add(pr);
                
                return result;
            }
            else
                return null;
        }    
    }
}

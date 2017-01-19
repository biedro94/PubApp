using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepository.Repository.Interface;
using Data.Model;

namespace Application.Service
{
    public class Service : IService
    {
        IRepository repo;

        public Service(IRepository _repo)
        {
            this.repo = _repo;
        }

        public Result<DMLResult> CreateOrderService(int Client_Id, int Table_Number, int ProductsList_Id)
        {
            DMLResult insert = new DMLResult();
            insert = repo.CreateOrder(Client_Id, Table_Number, ProductsList_Id);
            Result<DMLResult> result = new Result<DMLResult>(insert);
            result.InsertCheck();
            return result;            
        }
        public Result<DMLResult> RegisterUserService(string Client_Email, string Client_Password, string Client_Username)
        {
            DMLResult insert = new DMLResult();
            insert = repo.RegisterUser(Client_Email,Client_Password, Client_Username);
            Result<DMLResult> result = new Result<DMLResult>(insert);
            result.InsertCheck();
            return result;
        }

        public Result<List<Product>> GetListOfProductsService()
        {
            List<Product> productList = repo.GetListOfProducts();
            Result<List<Product>> result = new Result<List<Product>>(productList);
            result.ErrorIfDataNull();
            return result;
        }

        public Result<Client> LoginUserService(string Client_Email, string Client_Password)
        {
            Client cl = repo.LoginUser(Client_Email, Client_Password);
            Result<Client> result = new Result<Client>(cl);
            result.ErrorIfDataNull();
            return result;
        }

    }
}

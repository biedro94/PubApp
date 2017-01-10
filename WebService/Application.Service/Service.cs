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

    }
}

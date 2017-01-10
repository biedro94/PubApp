using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepository.Repository.Interface;
using Data.Model;

namespace BaseRepository.Repository.Implementation
{
    public class Repository : BaseRepository, IRepository
    {
        public DMLResult CreateOrder(int Client_Id, int Table_Number, int ProductsList_Id)
        {
            return SimpleDML("Order_AddOrder",
                new
                {
                    clientId = Client_Id,
                    tableNumber = Table_Number,
                    productsListId = ProductsList_Id
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Application.Service
{
    public interface IService
    {
        Result<DMLResult> CreateOrderService(int Client_Id, int Table_Number, int ProductsList_I);
        Result<DMLResult> RegisterUserService(string Client_Email, string Client_Password, string Client_Username);
        Result<List<Product>> GetListOfProductsService();
        Result<Client> LoginUserService(string Client_Email, string Client_Password);
    }
}

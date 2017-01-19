using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepository.Repository.Interface
{
    public interface IRepository
    {
        DMLResult CreateOrder(int Client_Id, int Table_Number, int ProductsList_Id);
        DMLResult RegisterUser(string Client_Email, string Client_Password,string Client_Username);
        List<Product> GetListOfProducts();
        Client LoginUser(string Client_Email, string Client_Password);
    }
}

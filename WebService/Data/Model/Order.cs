using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Order
    {
        int Order_Id { get; set; }
        int Client_Id { get; set; }
        int Order_Type { get; set; }
        int Order_Status { get; set; }
        int Table_Number { get; set; }
        DateTime Order_Date { get; set; }
        DateTime Order_AcceptDate { get; set; }
        DateTime Order_EndDate { get; set; }
        int ProductList_Id {get;set;}
    }
}

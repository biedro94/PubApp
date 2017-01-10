using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Product
    {
        int Product_Id { get; set; }
        string Product_Name { get; set; }
        int Quantity { get; set; }
        float Price { get; set; }
        string Description { get; set; }
        string Weight { get; set; }

    }
}

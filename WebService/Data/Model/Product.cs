using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public int Category_Id { get; set; }
    }
}

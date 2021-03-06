using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Product
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public string Name { get; set; }
        public double Retailprice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

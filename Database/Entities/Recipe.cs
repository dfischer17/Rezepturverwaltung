using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Costprice { get; set; }
        public List<Resource> Resources { get; set; }
    }
}

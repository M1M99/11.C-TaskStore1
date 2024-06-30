using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.C_StoreTask.Category
{
    public class BuildingMaterialsFCategory
    {
        public int Id { get; set; }
        public static int _id { get; set; } = 1;
        public decimal Price { get; set; }
        public string Name { get; set; }

        public BuildingMaterialsFCategory(decimal price,string name)
        {
            Id = _id++;
            Price = price;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}

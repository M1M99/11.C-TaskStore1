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
            Price = price;
            Name = name;
            try
            {
                if (_id <= /*methods.list1.Count()*/ 7)
                {
                    Id = _id++;
                }

                else
                {
                    _id = 1;
                    Id = _id++;
                }
            }
            catch { };
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}

namespace _11.C_StoreTask.Category
{
    public class Clothers
    {
        public int Id { get; set; }
        public static int _Id { get; set; } = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public Clothers() { }
        public Clothers(string name, string description, string material, string size, decimal price, string color) {
            Name = name;
            Description = description;
            Material = material;
            Size = size;
            Price = price;
            Color = color;
            try
            {
                if (_Id <= /*methods.ForClothers.Count()*/ 5)
                {
                     Id = _Id++;
                }

                else
                {
                    _Id = 1;
                    Id = _Id++;
                }
            }
            catch { };
        }
        public override string ToString()
        {
            return $"{Name} {Description} {Material} {Size} {Price} {Color}";
        }
    }
}

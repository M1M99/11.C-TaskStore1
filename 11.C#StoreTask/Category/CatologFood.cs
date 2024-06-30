namespace _11.C_StoreTask.Category
{
    public class CatalogOfFood
    {
        public int id { get; set; }
        public static int _id { get; set; } = 1;
        public string? NameOfFood { get; set; }
        public decimal Price { get; set; }
        public decimal Kcal { get; set; }
        public decimal Fat { get; set; }
        public decimal Sugar { get; set; }
        public decimal ProteinAmount { get; set; }
        public List<CatalogOfFood> list { get; set; }
        public CatalogOfFood() { }
        public CatalogOfFood(string? Name, decimal calori, decimal fat, decimal sugar, decimal protein, decimal price)
        {
            NameOfFood = Name;
            Kcal = calori;
            Fat = fat;
            Sugar = sugar;
            ProteinAmount = protein;
            Price = price;
            try
            {
                if (_id <= 5)
                {
                    id = _id++;
                }
                else
                {
                    _id = 1;
                    id = _id++;
                }
            }
            catch { };
        }
        public override string ToString()
        {
            return $"{id}. Product : {NameOfFood} |  Calori : {Kcal}   Fat : {Fat}   Sugar : {Sugar}     Protein : {ProteinAmount}     Price : {Price}";
        }
    }
}


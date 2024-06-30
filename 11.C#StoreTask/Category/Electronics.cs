namespace _11.C_StoreTask.Category
{
    public class Elect
    {
        public Elect(string? vendor, string? model, int ram, double rOM, string? color, decimal price)
        {
            Vendor = vendor;
            Model = model;
            Ram = ram;
            ROM = rOM;
            Color = color;
            Price = price;
        }
        public Elect()
        {

        }
        public string? Vendor { get; set; } = null;
        public string? Model { get; set; }
        public int Ram { get; set; }
        public double ROM { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public List<Phones>? PhonesL { get; set; }

        public override string ToString()
        {
            return ($"{Vendor} {Model} {Ram} {ROM} {Color} ");
        }
    }
    public class Television : Elect
    {

        public static int _tvId { get; set; } = 1;
        public int id1 { get; set; }

        public Television(string? vendor, string? model, int Diagonal, decimal price) : base(vendor, model, 0, 0, null, price)
        {
            Vendor = vendor;
            Model = model;
            this.Diagonal = Diagonal;
            Price = price;
            try
            {
                //MethodsForElect methods = new MethodsForElect();
                if (_tvId <= /*methods.list1.Count()*/ 5)
                {
                    id1 = _tvId++;
                }

                else
                {
                    _tvId = 1;
                    id1 = _tvId++;
                }
            }
            catch { };
        }
        public Television() { }

        public int Diagonal { get; set; }

        public override string ToString()
        {
            Television t = new Television();
            return ($"{id1} {Vendor} {Model} {Diagonal} {Price}");
        }

    }

    public class Modems : Elect
    {
        private static int _modemId { get; set; } = 1;
        private int Id { get; set; }

        public Modems(string? vendor, string? model, decimal price)
        {
            Vendor = vendor;
            Model = model;
            Price = price;
            try
            {
                //MethodsForElect methods = new MethodsForElect();
                if (_modemId <= /*methods.list2.Count()*/ 5)
                {
                    Id = _modemId++;
                }

                else
                {
                    _modemId = 1;
                    Id = _modemId++;
                }
            }
            catch { };
        }

        public Modems() { }

        public override string ToString()
        {
            Modems t1 = new Modems();
            return ($"{Id} {Vendor} {Model} {Price}");
        }
    }
    public class Phones : Elect
    {
        public static int _pID { get; set; } = 1;
        public int ID1 { get; set; }
        public Phones(string? vendor, string? model, int ram, double rOM, string? color, decimal price)
        {
            Vendor = vendor;
            Model = model;
            Ram = ram;
            ROM = rOM;
            Color = color;
            Price = price;
            try
            {
                //MethodsForElect methods = new MethodsForElect();
                if (_pID <= /*methods.list.Count()*/ 5)
                {
                    ID1 = _pID++;
                }

                else
                {
                    _pID = 1;
                    ID1 = _pID++;
                }
            }
            catch { };
        }
        public override string ToString()
        {
            return ($"{ID1} {Vendor} {Model} {Ram} {ROM} {Color} {Price}");
        }
    }
    public class Consoles : Elect
    {
        public Consoles(string vendor, string model, double Rom, decimal price) : base(vendor, model, 0, Rom, null, price)
        {

            Vendor = vendor;
            Model = model;
            ROM = Rom;
            Price = price;
            try
            {
                //MethodsForElect methods = new MethodsForElect();
                if (_CID <= /*methods.list3.Count()*/ 5)
                {
                    ID2 = _CID++;
                }

                else
                {
                    _CID = 1;
                    ID2 = _CID++;
                }
            }
            catch { };
        }
        public static int _CID { get; set; } = 1;
        public int ID2 { get; set; }

        public override string ToString()
        {
            return ($"{ID2} {Vendor} {Model} {ROM} {Price}");
        }
    }
}


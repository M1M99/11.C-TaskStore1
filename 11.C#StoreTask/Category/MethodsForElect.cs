using System.Collections.Generic;

namespace _11.C_StoreTask.Category
{
    public class MethodsForElect
    {
        public List<Phones> list = new()
        {
            new("iPhone", "XS", 4, 128, "Black", 550),
            new("Samsung", "S21", 8, 256, "Brown", 700),
            new("Samsung", "S24", 8, 512, "Black", 970),
            new("Honor", "Magic", 4, 64, "Yellow", 340),
            new("Xiaomi", "Note 10", 6, 128, "Purple", 600),
        };

        public void checkChoise()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Telefonun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < list.Count; i++)
                {
                    if (key == list[i].ID1)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    decimal amount = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (key == list[i].ID1)
                        {
                            amount += list[i].Price;
                        }
                    }
                }
                if (k == 2)
                {
                    goto go1;
                }
                if (k == 3)
                {
                    Menu menu = new Menu();
                    menu.ShowM();
                }
            }
            catch { };
        }

        public List<Television> list1 = new List<Television>()
        {
            new("Sony", "Bravia", 81,1450),
            new("Samsung","Z",90, 1700),
            new("HoffMan", "RT",41, 570),
            new("LG", "SJ",97,1340),
            new("Xiaomi", "8K",120, 2600),
        };
        public List<Modems> list2 = new List<Modems>()
        {
            new("Xiaomi","X1",90),
            new("Asus","Z1",190),
            new("Empty","A1",70),
            new("Xiaomi","C1",190),
            new("Acer","X1",91),

        };
        public List<Consoles> list3 = new List<Consoles>()
        {
            new("Sony","PS5",1,1090),
            new("Xbox","Series X",2,1190),
            new("Sony","PS3",0.5,470),
            new("Sony","PS2",0.1,100),
            new("Xbox","Serise S",1,1111),

        };

        public void foreachs()
        {
            foreach (Phones phone in list)
                Console.WriteLine(phone);
        }
        public void foreachs1()
        {
            foreach (Television TV in list1)
                Console.WriteLine(TV);
        }
        public void foreachs2()
        {
            foreach (Modems M in list2)
                Console.WriteLine(M);
        }
        public void foreachs3()
        {
            foreach (Modems M in list2)
                Console.WriteLine(M);
        }
        public void foreachs4()
        {
            foreach (Consoles C in list3)
                Console.WriteLine(C);
        }
    }
    public class MethodsForFoods
    {
        public List<CatalogOfFood> FruitAndVegetable = new() {
            new ("Apple",52,0,18,0.6m,1.9m),
            new ("Orange",49,0.2m,8.5m,0.9m,2.7m),
            new ("Pear",100,0.3m,0,6.0m,2.3m),
            new ("Tomato",13,0.2m,3.1m,0.7m,1.8m),
            new ("Patato",160,0.2m,6.1m,4.6m,1.7m),
        };
        public List<CatalogOfFood> MeatFishChickenProducts = new() {
            new ("Meat",143,3.5m,0,26,21),
            new ("Chicken",240,14,0,28,10),
            new ("Salmon",139 ,6.4m,0,23,35),
            new ("Farel",141 ,6 ,6.1m,20 ,45),
            new ("Atlantic Mackerel",262 ,18,0,24,2.3m),
        }; 
        public List<CatalogOfFood> MilkProducts = new () {
            new ("Milk",90,3.5m,0,5,2),
            new ("Yogurt",240,14,0,28,5),
            new ("Cheese",139 ,6.4m,0,18,17),
            new ("Cream",200 ,39 ,6.1m,20 ,6), // random
            new ("Butter",560 ,70,0,16,10),
        }; 
        public List<CatalogOfFood> Drink = new() {
            new ("Water",0,0,0,0,1),
            new ("MineralWater",12 ,0,0,2.1m,1),
            new ("EnergyDrink",120,0,5,4,3),
            new ("Tea",3 ,0,0,2,2),
            new ("Coffee",41 ,5 ,6.1m,2 ,3),
        }; 
        public List<CatalogOfFood> Bread = new() {
            new ("Black Bread.",260,3.5m,5,8,2),
            new ("White Bread",270,14,6,9,1),
            new ("Lavash",300 ,6.4m,4,5,2),
            new ("Tandir",290 ,6 ,6.1m,8 ,1),
            new ("Bread(Cutted)",270 ,18,5,9,2.5m),
        };

        #region Methods

        public void foreach1()
        {
            Console.WriteLine("Id");
            foreach(CatalogOfFood ite1m in FruitAndVegetable)
            {
                Console.WriteLine(ite1m);
            }
        }
        public void foreach2()
        {
            foreach(CatalogOfFood item in MeatFishChickenProducts)
            {
                Console.WriteLine(item);
            }
        }public void foreach3()
        {
            foreach(var item in MilkProducts)
            {
                Console.WriteLine(item.ToString());
            }
        }public void foreach4()
        {
            foreach(var item in Drink)
            {
                Console.WriteLine(item);
            }
        }public void foreach5()
        {
            foreach(var item in Bread)
            {
                Console.WriteLine(item);
            }
        }

        internal void foreachforb()
        {
            throw new NotImplementedException();
        }
        #endregion methods


    }
    public class MethodsForBuilding
    {
        List<BuildingMaterialsFCategory> buildings = new()
        {
            new(9,"Gips"),
            new(15,"Knife"),
            new(10,"Cement"),
            new(25,"Brick"),
            new(27,"Wood"),
            new(17,"Glass"),
            new(7,"Stone"),
        };
        public void foreachforb1()
        {
            foreach(var item in buildings)
            {
                Console.WriteLine(item);
            }
            checkChoise();
        }

        public void checkChoise()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Materialin Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < buildings.Count; i++)
                {
                    if (key == buildings[i].Id)
                    {
                        Console.WriteLine(buildings[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    decimal amount = 0;
                    for (int i = 0; i < buildings.Count; i++)
                    {
                        if (key == buildings[i].Id)
                        {
                            amount += buildings[i].Price;
                            Console.WriteLine(amount);
                            Console.ReadLine();
                        }
                    }
                }
                if (k == 2)
                {
                    goto go1;
                }
                if (k == 3)
                {
                    Menu menu = new Menu();
                    menu.ShowM();
                }
            }
            catch { };
        }

    }
    public class MethodsForClothers
    {
        List<Clothers> ForClothers = new()
        {
            new("Jeans","100% Cotton Men Jeans","100% Cotton","34",45,"Black"),
            new("SweatShirt","100% Cotton Men SweatShirt","100% Cotton","XL",30,"Blue"),
            new("Jacket","Quality Men Jacket","50% Leather 50% Cotton","34",45,"Green"),
            new("Coat","Coat Quality","14% Cotton 86% Polyester","34",45,"Grey"),
            new("Boots","100% Real Leather Men Boots","100% Leather","34",45,"Black"),
            new("T-Shirt","100% Cotton Men T-Shirt","100% Cotton","34",45,"Brown"),
        };
        public void foreachforclothers()
        {
            foreach (var item in ForClothers)
            {
                Console.WriteLine(item);
            }
            checkChoise();
        }

        public void checkChoise()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Paltarin Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ForClothers.Count; i++)
                {
                    if (key == ForClothers[i].Id)
                    {
                        Console.WriteLine(ForClothers[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    decimal amount = 0;
                    for (int i = 0; i < ForClothers.Count; i++)
                    {
                        if (key == ForClothers[i].Id)
                        {
                            amount += ForClothers[i].Price;
                            Console.WriteLine(amount);
                            Console.ReadLine();
                        }
                    }
                }
                if (k == 2)
                {
                    goto go1;
                }
                if (k == 3)
                {
                    Menu menu = new Menu();
                    menu.ShowM();
                }
            }
            catch { };
        }

    }
}

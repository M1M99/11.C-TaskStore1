using _11.C_StoreTask.Files;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace _11.C_StoreTask.Category
{
    public class Amount
    {
        public static decimal g = 0;
        public decimal Price { get; set; }

        public Amount(decimal value)
        {
            Price = value;
        }
        public static Amount operator +(Amount a, decimal b)
        {
            return new Amount(a.Price + b);
        }

        public override string ToString()
        {
            return $"{Price}";
        }
    }
    public class L
    {
        public List<string> list1s = new List<string>();
        public L(string a)
        {
            list1s.Add(a);
        }
    }
    public class L1
    {
        public static List<string> list11s = new List<string>();
    }
    public class MethodsForElect
    {
        public static List<Phones> list = new()
        {
            new("iPhone", "XS", 4, 128, "Black", 550),
            new("Samsung", "S21", 8, 256, "Brown", 700),
            new("Samsung", "S24", 8, 512, "Black", 970),
            new("Honor", "Magic", 4, 64, "Yellow", 340),
            new("Xiaomi", "Note 10", 6, 128, "Purple", 600),
        };
        List<string> list12s = new List<string>();
        decimal amount1b = 0;
        public void checkChoise()
        {
        go1:
            try
            {
                Console.Write("Alacaginiz Telefonunu Id i Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < list.Count; i++)
                {
                    if (key == list[i].ID1)
                    {
                        Console.WriteLine(list[i]);
                    }
                }

                Console.WriteLine("1. Confirm Order!");
                Console.WriteLine("2. Go back.");
                Console.WriteLine("3. Menu.");
                Console.WriteLine("4. Card!");
                Console.Write("Choice: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (key == list[i].ID1)
                        {
                            L m = new(list[i].ToString());
                            list12s.Add(list[i].ToString());
                            Amount.g += list[i].Price;
                            Console.WriteLine("Selected Phones:");
                            foreach (var s in list12s)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(m.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
                if (k == 4)
                {
                    var t = File.ReadAllText("F.json");
                    Console.WriteLine(t);
                }
            }
            catch { };
            
        }
        static int _id1 = 0;
        public void cardM()
        {
            var id = _id1++;
            try
            {
                Console.Clear();
                if (!File.Exists("F.json"))
                {
                    Console.WriteLine("Your Cart Is Empty!");
                }
                var t = File.ReadAllText("F.json");
                t = t.Replace("[", "\n").Replace("]", "\n").Replace('"', '\b').Trim();
                Console.WriteLine(t);
                Console.Write("Current Amount : ");
                decimal k = (Amount.g);
                Console.WriteLine(k);
                //Console.WriteLine("1. Sil");
                //int y = Convert.ToInt32(Console.ReadLine());
                //if (y == 1)
                //{
                //}
            H:
                Console.Write("Odenilecek Meblegi Daxil et : ");// vergul ile daxil et.
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                try
                {
                    if (amount >= k)
                    {
                        if (amount == k)
                        {
                            Console.WriteLine("Successfull Order");
                        }
                        if (amount > k)
                        {
                            var g = amount - k;
                            Console.WriteLine($"Qaliq : {g}");
                        }
                        var f1 = File.ReadAllText("F.json");
                        L1.list11s.Add(f1);
                        File.Delete("F.json");
                    }
                    else
                    {
                        throw new Exception("You Included Less From Your Dept!");

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); goto H; };
            }
            catch (Exception ex) { };
        }
        public void cosWrite()
        {
            foreach (var f in L1.list11s)
            {
                Console.WriteLine(f);
            }
        }
        public void RemovecardM()
        {
            list12s.Clear();
            string jsonContent = JsonSerializer.Serialize(list12s);
            File.WriteAllText("F.json", jsonContent);
            Console.WriteLine("List Cleaned");
        }

        public List<Television> list1 = new List<Television>()
        {
            new("Sony", "Bravia", 81,1450),
            new("Samsung","Z",90, 1700),
            new("HoffMan", "RT",41, 570),
            new("LG", "SJ",97,1340),
            new("Xiaomi", "8K",120, 2600),
        };

        public void checkChoise1()
        {
        go1:
            try
            {
                Console.Write("Alacaginiz Telefonunu Id i Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < list1.Count; i++)
                {
                    if (key == list1[i].id1)
                    {
                        Console.WriteLine(list1[i]);
                    }
                }
                Console.WriteLine("1. Confirm Order!");
                Console.WriteLine("2. Go back.");
                Console.WriteLine("3. Menu.");
                Console.WriteLine("4. Card!");
                Console.Write("Choice: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        if (key == list1[i].id1)
                        {
                            L m = new(list1[i].ToString());
                            list12s.Add(list1[i].ToString());
                            Amount.g += list1[i].Price;
                            Console.WriteLine("Selected Phones:");
                            foreach (var s in list12s)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(m.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
                if (k == 4)
                {
                    var t = File.ReadAllText("F.json");
                    Console.WriteLine(t);
                }
            }
            catch { };
        }

        public List<Modems> list2 = new List<Modems>()
        {
            new("Xiaomi","X1",90),
            new("Asus","Z1",190),
            new("Empty","A1",70),
            new("Xiaomi","C1",190),
            new("Acer","X1",91),

        };

        public void checkChoise2()
        {
        go1:
            try
            {
                Console.Write("Alacaginiz Telefonunu Id i Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < list2.Count; i++)
                {
                    if (key == list2[i].Id)
                    {
                        Console.WriteLine(list2[i]);
                    }
                }

                Console.WriteLine("1. Confirm Order!");
                Console.WriteLine("2. Go back.");
                Console.WriteLine("3. Menu.");
                Console.WriteLine("4. Card!");
                Console.Write("Choice: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (key == list2[i].Id)
                        {
                            L m = new(list2[i].ToString());
                            list12s.Add(list2[i].ToString());
                            Amount.g += list2[i].Price;
                            Console.WriteLine("Selected Phones:");
                            foreach (var s in list12s)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(m.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
                if (k == 4)
                {
                    var t = File.ReadAllText("F.json");
                    Console.WriteLine(t);
                }
            }
            catch { };
        }

        public List<Consoles> list3 = new List<Consoles>()
        {
            new("Sony","PS5",1,1090),
            new("Xbox","Series X",2,1190),
            new("Sony","PS3",0.5,470),
            new("Sony","PS2",0.1,100),
            new("Xbox","Serise S",1,1111),

        };

        public void checkChoise3()
        {
        go1:
            try
            {
                Console.Write("Alacaginiz Telefonunu Id i Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < list3.Count; i++)
                {
                    if (key == list3[i].ID2)
                    {
                        Console.WriteLine(list3[i]);
                    }
                }

                Console.WriteLine("1. Confirm Order!");
                Console.WriteLine("2. Go back.");
                Console.WriteLine("3. Menu.");
                Console.WriteLine("4. Card!");
                Console.Write("Choice: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < list3.Count; i++)
                    {
                        if (key == list3[i].ID2)
                        {
                            L m = new(list3[i].ToString());
                            list12s.Add(list3[i].ToString());
                            Amount.g += list3[i].Price;
                            Console.WriteLine("Selected Phones:");
                            foreach (var s in list12s)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(m.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
                if (k == 4)
                {
                    var t = File.ReadAllText("F.json");
                    Console.WriteLine(t);
                }
            }
            catch { };
        }


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
        List<string> listse = new List<string>();
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
        public List<CatalogOfFood> MilkProducts = new() {
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
            foreach (CatalogOfFood ite1m in FruitAndVegetable)
            {
                Console.WriteLine(ite1m);
            }
        }
        public void foreach2()
        {
            foreach (CatalogOfFood item in MeatFishChickenProducts)
            {
                Console.WriteLine(item);
            }
        }
        public void foreach3()
        {
            foreach (var item in MilkProducts)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void foreach4()
        {
            foreach (var item in Drink)
            {
                Console.WriteLine(item);
            }
        }
        public void foreach5()
        {
            foreach (var item in Bread)
            {
                Console.WriteLine(item);
            }
        }
        //public virtual void CheckChoice(List<CatalogOfFood> products)
        //{
        //go1:
        //    try
        //    {
        //        Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
        //        int key = Convert.ToInt32(Console.ReadLine());
        //        for (int i = 0; i < products.Count; i++)
        //        {
        //            if (key == products[i].id)
        //            {
        //                Console.WriteLine(products[i]);
        //            }
        //        }
        //        Console.WriteLine("1. Sifarisi Testiq Et ! ");
        //        Console.WriteLine("2. Geri. ");
        //        Console.WriteLine("3. Menu. ");
        //        Console.Write("Secim : ");
        //        int k = Convert.ToInt32(Console.ReadLine());
        //        if (k == 1)
        //        {
        //            for (int i = 0; i < products.Count; i++)
        //            {
        //                if (key == products[i].id)
        //                {
        //                    L l = new(products[i].ToString());
        //                    listse.Add(products[i].ToString());
        //                    Amount.g += products[i].Price;
        //                    Console.WriteLine("Selected Foods:");
        //                    foreach (var s in listse)
        //                    {
        //                        Console.WriteLine(s);
        //                    }
        //                    string jsonContent = JsonSerializer.Serialize(l.list1s);
        //                    File.AppendAllText("F.json", jsonContent); Console.WriteLine();
        //                    Console.WriteLine("Sebete Elave Olundu!");
        //                }
        //            }
        //        }
        //        if (k == 2)
        //        {
        //            goto go1;
        //        }
        //        if (k == 3)
        //        {
        //            Menu menu = new Menu();
        //            menu.ShowM();
        //        }
        //    }
        //    catch { };
        //}
        public void CheckChoiseFruits()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < FruitAndVegetable.Count; i++)
                {
                    if (key == FruitAndVegetable[i].id)
                    {
                        Console.WriteLine(FruitAndVegetable[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < FruitAndVegetable.Count; i++)
                    {
                        if (key == FruitAndVegetable[i].id)
                        {
                            L l1 = new(FruitAndVegetable[i].ToString());
                            listse.Add(FruitAndVegetable[i].ToString());
                            Amount.g += FruitAndVegetable[i].Price;
                            Console.WriteLine("Selected Foods:");
                            foreach (var s in listse)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(l1.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        public void checkChoiseForMeat()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < MeatFishChickenProducts.Count; i++)
                {
                    if (key == MeatFishChickenProducts[i].id)
                    {
                        Console.WriteLine(MeatFishChickenProducts[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < MeatFishChickenProducts.Count; i++)
                    {
                        if (key == MeatFishChickenProducts[i].id)
                        {
                            L l2 = new(MeatFishChickenProducts[i].ToString());
                            listse.Add(MeatFishChickenProducts[i].ToString());
                            Amount.g += MeatFishChickenProducts[i].Price;
                            Console.WriteLine("Selected Foods:");
                            foreach (var s in listse)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(l2.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        public void checkChoiseForMilkProducts()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < MilkProducts.Count; i++)
                {
                    if (key == MilkProducts[i].id)
                    {
                        Console.WriteLine(MilkProducts[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < MilkProducts.Count; i++)
                    {
                        if (key == MilkProducts[i].id)
                        {
                            L l12 = new(MilkProducts[i].ToString());
                            listse.Add(MilkProducts[i].ToString());
                            Amount.g += MilkProducts[i].Price;
                            Console.WriteLine("Selected Foods:");
                            foreach (var s in listse)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(l12.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        public void checkChoiseForDrink()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Drink.Count; i++)
                {
                    if (key == Drink[i].id)
                    {
                        Console.WriteLine(Drink[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < Drink.Count; i++)
                    {
                        if (key == Drink[i].id)
                        {
                            L l123 = new(Drink[i].ToString());
                            listse.Add(Drink[i].ToString());
                            Amount.g += Drink[i].Price;
                            Console.WriteLine("Selected Foods:");
                            foreach (var s in listse)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(l123.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        public void checkChoiseForBread()
        {
        go1:
            try
            {
                Console.Write("Almaq Istediyiniz Mehsulun Sira Nomresini Daxil Edin : ");
                int key = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Bread.Count; i++)
                {
                    if (key == Bread[i].id)
                    {
                        Console.WriteLine(Bread[i]);
                    }
                }
                Console.WriteLine("1. Sifarisi Testiq Et ! ");
                Console.WriteLine("2. Geri. ");
                Console.WriteLine("3. Menu. ");
                Console.Write("Secim : ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    for (int i = 0; i < Bread.Count; i++)
                    {
                        if (key == Bread[i].id)
                        {
                            L l123 = new(Bread[i].ToString());
                            listse.Add(Bread[i].ToString());
                            Amount.g += Bread[i].Price;
                            Console.WriteLine("Selected Foods:");
                            foreach (var s in listse)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(l123.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        #endregion methods
    }
    public class MethodsForBuilding
    {
        List<string> listsed1 = new List<string>();
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
            foreach (var item in buildings)
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
                    for (int i = 0; i < buildings.Count; i++)
                    {
                        if (key == buildings[i].Id)
                        {
                            L lL45 = new(buildings[i].ToString());
                            listsed1.Add(buildings[i].ToString());
                            Amount.g += buildings[i].Price;
                            Console.WriteLine("Selected Materials:");
                            foreach (var s in listsed1)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(lL45.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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
        List<string> ls = new();
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
                Console.Clear();
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
                            L lL12 = new(ForClothers[i].ToString());
                            ls.Add(ForClothers[i].ToString());
                            Amount.g += ForClothers[i].Price;
                            Console.WriteLine("Selected Materials:");
                            foreach (var s in ls)
                            {
                                Console.WriteLine(s);
                            }
                            string jsonContent = JsonSerializer.Serialize(lL12.list1s);
                            File.AppendAllText("F.json", jsonContent); Console.WriteLine();
                            Console.WriteLine("Sebete Elave Olundu!");
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

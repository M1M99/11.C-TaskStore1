using _11.C_StoreTask.Category;
using Microsoft.VisualBasic;

namespace _11.C_StoreTask
{
    public class Categorys
    {
        MethodsForFoods methods1 = new();
        MethodsForElect m = new();
        public void Showcategory()
        {
            Console.WriteLine("1. Inshaat Materiallari");
            Console.WriteLine("2. Qida");
            Console.WriteLine("3. Ichki");
            Console.WriteLine("4. Paltar");
            Console.WriteLine("5. Elektronika");
            Console.WriteLine("6. Sebet");
            Console.WriteLine("7. Log Out");
            Console.WriteLine("8. History(Empty)");
            var k = (Console.ReadKey());
            if (k.Key == ConsoleKey.D1)
            {
                Console.Clear();
                MethodsForBuilding forBuilding = new MethodsForBuilding();
                forBuilding.foreachforb1();
                Console.ReadLine();
            }
            if (k.Key == ConsoleKey.D2)
            {
            l1:
                Console.Clear();
                Console.WriteLine("1. Meyve ve terevez");
                Console.WriteLine("2. Et, toyuq ve deniz mehsulları");
                Console.WriteLine("3. Süd mehsulları");
                Console.WriteLine("4. Alkoqolsuz içkiler");
                Console.WriteLine("5. Chorek mehsulları");
                var t = Console.ReadKey();
                switch (t.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        methods1.foreach1();
                        methods1.CheckChoiseFruits();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        methods1.foreach2();
                        methods1.checkChoiseForMeat();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        methods1.foreach3();
                        methods1.checkChoiseForMilkProducts();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        methods1.foreach4();
                        methods1.checkChoiseForDrink();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        methods1.foreach5();
                        methods1.checkChoiseForBread();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("False!");
                        break;
                }
            }
            if (k.Key == ConsoleKey.D3)
            {
                Console.Clear();
                methods1.foreach4();
                methods1.checkChoiseForDrink();
                Console.ReadLine();
            }
            if (k.Key == ConsoleKey.D4)
            {
                //MethodsForElect methodsForElect = new MethodsForElect();
                Console.Clear();
                MethodsForClothers forClothers = new MethodsForClothers();
                forClothers.foreachforclothers();
                //methodsForElect.checkChoise();
                Console.ReadLine();
            }
            if (k.Key == ConsoleKey.D5)
            {
                MethodsForElect methods = new MethodsForElect();
                Console.Clear();
                Console.WriteLine("1. Phones.");
                Console.WriteLine("2. Televisions.");
                Console.WriteLine("3. Modems.");
                Console.WriteLine("4. GameConsoles");
                var r1 = Console.ReadKey();
                if (r1.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    methods.foreachs();
                    methods.checkChoise();
                    Console.ReadKey();
                }
                if (r1.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    methods.foreachs1();
                    methods.checkChoise1();
                    Console.ReadKey();
                }
                if (r1.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    methods.foreachs2();
                    methods.checkChoise2();
                    Console.ReadKey();
                }
                if (r1.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    methods.foreachs4();
                    methods.checkChoise3();
                    Console.ReadKey();
                }
            }
            if (k.Key == ConsoleKey.D6)
            {
                m.cardM();
                Console.ReadKey();
            }
                Menu menumain = new Menu();
            if (k.Key == ConsoleKey.D7)
            {
                Console.WriteLine("Logged Out From Account");
                m.RemovecardM();
                Console.Clear();
                Console.WriteLine("Wait !");
                Thread.Sleep(2000);
                menumain.ShowM();
            }
            if (k.Key == ConsoleKey.D8)
            {
                MethodsForElect l = new();
                try
                {
                    l.cosWrite();
                    Console.ReadLine();
                }
                catch { }
            }
        }
    }
}

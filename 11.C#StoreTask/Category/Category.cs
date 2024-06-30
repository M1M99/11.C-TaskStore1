using _11.C_StoreTask.Category;

namespace _11.C_StoreTask
{
    public class Categorys
    {
        MethodsForFoods methods1 = new();
        public void Showcategory()
        {
            Console.WriteLine("1. Inshaat Materiallari");
            Console.WriteLine("2. Qida");
            Console.WriteLine("3. Ichki");
            Console.WriteLine("4. Paltar");
            Console.WriteLine("5. Elektronika");
            var k = (Console.ReadKey());
            if (k.Key == ConsoleKey.D1)
            {
                Console.Clear();
                MethodsForBuilding forBuilding = new MethodsForBuilding();
                forBuilding.foreachforb1();
                Console.ReadLine() ;
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
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        methods1.foreach2();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Thread.Sleep(10000);
                        methods1.foreach3();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        methods1.foreach4();
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        methods1.foreach5();
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
                Console.ReadLine();
            }
            if (k.Key == ConsoleKey.D4)
            {
                Console.Clear();
                MethodsForClothers forClothers = new MethodsForClothers();
                forClothers.foreachforclothers();
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
                    Console.ReadKey();
                }
                if (r1.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    methods.foreachs2();
                    Console.ReadKey();
                }
                if (r1.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    methods.foreachs4();
                    Console.ReadKey();
                }
            }
        }
    }
}

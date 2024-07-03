using _11.C_StoreTask.Category;
using _11.C_StoreTask.Files;

namespace _11.C_StoreTask
{
    public class Menu
    {
        MethodsForElect methodsForElect = new MethodsForElect();
        SignIn I = new SignIn();
        Login l = new Login();
        public void ShowM()
        {
        go2:
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit From Program");
            Console.WriteLine("4. Card");
            Console.WriteLine("Choise:");
            var i = Console.ReadKey();
            if (i.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Sign In : ");
            checkname:
                try
                {
                    Console.Write("Enter Your Name : ");
                    string i1 = Console.ReadLine();
                    if (i1 == string.Empty)
                    {
                        throw new ArgumentException("Name Can Not Be Space or Empty !");
                    }
                    Console.Write("Enter Your PassWord : "); l:
                    string i2 = Console.ReadLine();
                    if (i2 == string.Empty)
                    {
                        throw new Exception("PassWord Can Not Be Space or Empty !");
                    }
                    I.Sign(i1, i2);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Name Can Not Be Space or Empty !");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto checkname;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("PassWord Can Not Be Space or Empty !");
                    goto checkname;
                }
            }
            else if (i.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.Write("Enter Your Name : ");
                string? i4 = Console.ReadLine();
                Console.Write("Enter Your PassWord : ");
                string? i5 = Console.ReadLine();
                if (i5 is not null && i4 is not null)
                {
                    l.Login1(i4, i5);
                }
            }
            if (i.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Exit Is Successful !");
                Environment.Exit(0);
            }
            if (i.Key == ConsoleKey.D4)
            {
                Console.Clear();    
                methodsForElect.cardM();
            }
            else
            {
                Console.Clear();
                goto go2;
            }
        }
    }
}

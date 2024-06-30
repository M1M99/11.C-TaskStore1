using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _11.C_StoreTask.Files
{
    public class Login
    {
    SignIn kl = new SignIn();
    
        public string? Name { get; set; }
        public string? Password { get; set; }

        public void Login1(string name, string PassWord)
        {
            bool loggedIn = false;
            foreach (var item in SignIn.ReadJsonAll())
            {
                if (item.name1 == name && item.PasssW == PassWord)
                {
                    loggedIn = true;
                    break;
                }
            }
            if (loggedIn)
            {
                Console.Clear();
                Categorys category = new Categorys();
                Console.WriteLine("Successful");
                category.Showcategory();
                //Console.WriteLine("Davam Etmek Ucun - Enter.");
                //Console.ReadKey();
            } 
            else
            {
                Console.WriteLine("User Has Not Found");
                Thread.Sleep(2000);
            }
        }
    }
}

using System.Text.Json;
namespace _11.C_StoreTask.Files
{
    public class SignIn
    {
        public string? name1 { get; set; }
        public string? PasssW { get; set; }
        public List<Item> list { get; set; }

        public SignIn()
        {
            list = new List<Item>();
        }

        public void AddItem(Item item)
        {
            list.Add(item);
        }

        public static List<SignIn> ReadJsonAll()
        {
            List<SignIn> allSignIns = new List<SignIn>();

            if (File.Exists("Users.json"))
            {
                string json = File.ReadAllText("Users.json");
                allSignIns = JsonSerializer.Deserialize<List<SignIn>>(json);
            }

            return allSignIns;
        }

        public void WriteToFile()
        {
            List<SignIn> all = ReadJsonAll();
            all.Add(this);
            string jsonSignIn = JsonSerializer.Serialize(all);
            File.WriteAllText("Users.json", jsonSignIn);
        }

        public List<SignIn> ReadFromFile()
        {
            List<SignIn> AllSign = new List<SignIn>();

            if (File.Exists("Users.json"))
            {
                string json = File.ReadAllText("Users.json");
                AllSign = JsonSerializer.Deserialize<List<SignIn>>(json);
            }
            return AllSign;
        }
        public void Sign(string? Names, string? PasssWord)
        {
            Console.WriteLine($"{Names} {PasssWord}");
            {
                var signIn = new SignIn { name1 = Names, PasssW = PasssWord };
                var i = new Item(name1 = Names ,PasssW = PasssWord);
                signIn.list.Add(i);
                WriteToFile();
                Console.WriteLine("Data saved");
                Thread.Sleep(2500);
                Console.Clear();
            }
        }
    }
}


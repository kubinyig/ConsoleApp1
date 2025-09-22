using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rng = new Random();
        static List<int> data = new List<int>();
        static void Main(string[] args)
        {
            initializeList();
            while (true) {
            int chosennumber = mainMenu();
            menuSwitch(chosennumber);
            Console.Clear();
            }

        }
        static int checkNum() {
            int chosennumber = 0;
            if (!int.TryParse(Console.ReadLine(), out chosennumber))
            {
                Console.WriteLine("Nem számot adott meg!");
                return -1;
            }
            else
            {
                return chosennumber;
            }
        }
        static void initializeList()
        {
            for (int i = 0; i < 10; i++)
            {
                data.Add(rng.Next(0, 100));
            }
        }
        static int mainMenu() { 
        int line = 1;
        string message1 = "1. adatok listázása";
            string message2 = "2. adatok létrehozása";
            string message3 = "3.  legnagyobb adat";
            string message4 = "4.  legkisebb adat";
            string message5 = "5. adatok törlése";
            string message6 = "6.  kilépés";
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("1. adatok listázása");
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("2. adatok létrehozása");
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("3.  legnagyobb adat");
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("4.  legkisebb adat");
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("5. adatok törlése");
            Console.SetCursorPosition((Console.WindowWidth - message1.Length) / 2, line);
            line++;
            Console.WriteLine("6.  kilépés");
            int chosennumber = checkNum();
            if (chosennumber < 1 || chosennumber > 6)
            {
                Console.WriteLine("Nem megfelelő számot adott meg!");
                return -1;
            }
            return chosennumber;
        }
        static void menuSwitch(int chosennumber)
        {
            switch (chosennumber)
            {
                case 1:
                    Console.WriteLine(string.Join(";", data));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Írja be a hozzáadni kívánt számot");
                    data.Add(checkNum());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Legnagyobb adat: " +Convert.ToString(data.Max()));
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Legkisebb adat: " + Convert.ToString(data.Min()));
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Adatok törlése: ");
                    Console.WriteLine(string.Join(";", data));
                    data.Remove(checkNum());
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Kilépés");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

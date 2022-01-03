using System;
using ThisPointerApp.Modal;

namespace ThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(10, "Neel", 25);
            PrintInfo(p1);
            Player p2 = new Player(20, "kannan");
            PrintInfo(p2);

            Player sachin = new Player(10001, "Sachin", 45);
            PrintInfo(sachin);
            Player virat = new Player(10002, "Virat", 35);
            PrintInfo(virat);

            Player elder = sachin.WhoisElder(virat);
            PrintInfo(elder);
        }
        static void PrintInfo(Player play)
        {
            Console.WriteLine("ID: " + play.ID);
            Console.WriteLine("Name: " + play.Name);
            Console.WriteLine("Age: " + play.Age + "\n");
        }

    }
}

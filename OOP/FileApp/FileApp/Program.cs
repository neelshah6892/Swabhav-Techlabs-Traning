using System;
using System.IO;
using System.Text;

namespace FileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter("Data.txt", append: true))
            {
                file.WriteLine("Neel");
                file.WriteLine("Shah");
                file.WriteLine("Swabhav");
            }
            string readtxt = File.ReadAllText("Data.txt");
            Console.WriteLine(readtxt);
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] rtxt = File.ReadAllLines("Data.txt");
            Console.WriteLine(rtxt);
            foreach (string line in rtxt)

            {

                if (line.Contains("Shah"))

                {

                    temp = line.Replace("Shah", "Hello");

                    newFile.Append(temp + "\r\n");

                    continue;

                }

                newFile.Append(line + "\r\n");

            }
            File.WriteAllText("Data.txt", newFile.ToString());
            Console.WriteLine(rtxt);
        }
    }
}

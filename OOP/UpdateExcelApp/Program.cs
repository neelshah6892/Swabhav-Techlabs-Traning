using System;
using System.IO;
using System.Text;

namespace UpdateExcelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readtxt = File.ReadAllLines("C:\\Users\\rocki\\Downloads\\Telegram Desktop\\emp_clean.csv");
            //Console.WriteLine(readtxt);
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            foreach (string line in readtxt)

            {

                if (line.Contains("KING-WEB"))

                {

                    temp = line.Replace("KING-WEB", "NEEL");

                    newFile.Append(temp + "\r\n");

                    continue;

                }

                newFile.Append(line + "\r\n");

            }
            File.WriteAllText("Data.csv", newFile.ToString());
            Console.WriteLine(readtxt);

            if (File.Exists("Data.csv"))
            {
                string newFileName = "emp_clean.csv";

                if (newFileName != String.Empty)
                {

                    // Renaming the file
                    File.Move("Data.csv", newFileName);

                    // checking if the file has been
                    // renamed successfully or not
                    if (File.Exists(newFileName))
                    {
                        Console.WriteLine("The file was renamed to " + newFileName);
                        Console.ReadKey();
                    }
                }
            }


        }
    }
}

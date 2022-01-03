using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using EmployeeBusinessModelApp.Modal;

namespace EmployeeBusinessModelApp
{
    class Program
    {
        static WebClient client = null;
        static string filepath = @"D://emp.txt";
        static void Main(string[] args)
        {
            string url = "https://swabhav-tech.firebaseapp.com/emp.txt";
            Console.WriteLine(url);
            DownloadFile(url);

            

            string[] lines = File.ReadAllLines(filepath);
            using (StreamReader read = new StreamReader(filepath))
            {
                HashSet<String> employee = new HashSet<String>();
                for (int i = 0; i<lines.Length; i++)
                {
                    char[] spearator = { ',', ' ' };
                    string[] strlist = lines[i].Split(spearator);
                    employee.Add(lines[i]);
                    Employee employees = new Employee(int.Parse(strlist[0]), strlist[1], strlist[2], int.Parse(strlist[3]), strlist[4], int.Parse(strlist[5]), strlist[6], int.Parse(strlist[7]));
                }

                foreach (string emp in employee)
                {
                    Console.WriteLine(emp);
                }
                //Console.WriteLine("Max Salary: ");
            }

            
            //Total number of employees based on designation


            //Total number of employees based on department no
        }

        public static void DownloadFile(string urlAddress)
        {
            client = new WebClient();
            client.DownloadFile(urlAddress, filepath);
        }
    }
}
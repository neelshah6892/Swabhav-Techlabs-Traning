using SerializationApp.Modal;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeserializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                Student s = (Student)formatter.Deserialize(stream);
                Console.WriteLine("Rollno: " + s.rollno);
                Console.WriteLine("Name: " + s.name);

                stream.Close();
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            
        }
    }
}

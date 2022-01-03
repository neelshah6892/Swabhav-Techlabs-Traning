using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SerializationApp.Modal;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();

                Student s = new Student(101, "Neel");
                formatter.Serialize(stream, s);

                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Serial_deserial_demo
{
    [Serializable]
    class Deserial_Pereson
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("e://person.txt", FileMode.Open);
            Console.WriteLine("=================First person details===========");
            BinaryFormatter bfm = new BinaryFormatter();
            Serial_person p = (Serial_person)bfm.Deserialize(fs);
            show(p);
            Console.WriteLine("=================Second person details===========");
            Serial_person p1 = (Serial_person)bfm.Deserialize(fs);
            show(p1);
               
            Console.ReadLine();
        }
        public static void show(Serial_person p)
        {
            Console.WriteLine("person id = " + p.person_id);
            Console.WriteLine("person name = " + p.name);
            Console.WriteLine("person address = " + p.address);
            Console.WriteLine("person email = " + p.email);
            Console.WriteLine("person pwd = " + p.pwd);

        }
    }
}

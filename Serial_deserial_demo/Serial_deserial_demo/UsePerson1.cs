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
    class UsePerson1
    {
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream("e://person1.txt", FileMode.Open);
            BinaryFormatter bfm = new BinaryFormatter();
            person_using_setget p1 = (person_using_setget)bfm.Deserialize(fs);
            
            
            Console.WriteLine("===========First  Person is================ ");
            ReadPerson(p1);
            Console.WriteLine("===========Second  Person is=============== ");
            p1 = (person_using_setget)bfm.Deserialize(fs);
            ReadPerson(p1);
            p1 = (person_using_setget)bfm.Deserialize(fs);
            Console.WriteLine("===========Third  Person is================ ");
            ReadPerson(p1);
            Console.ReadLine();
            fs.Close();
        }
        public static void ReadPerson(person_using_setget p)
        {
            Console.WriteLine("person Id=" + p[0]);
            Console.WriteLine("person Name=" + p[1]);
            Console.WriteLine("person Age=" + p[2]);
            Console.WriteLine("person Salary=" + p[3]);
         
        }
    }
}

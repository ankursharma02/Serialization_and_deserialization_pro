using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serial_deserial_demo
{


    [Serializable]
   public class Serial_person
    {

        public int person_id;
        public string name;
        public string address;
        public string email;
        [NonSerialized]
        public string pwd;
        public Serial_person(int person_id, string name, string email, string address, string pwd)
        {
            this.person_id = person_id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.pwd = pwd;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("e:/person.txt", FileMode.OpenOrCreate);
            BinaryFormatter bfm = new BinaryFormatter();
            Serial_person sp = new Serial_person(101, "ankur", "jaipur", "a.a.com", "nopwd");
            bfm.Serialize(fs, sp);
            Serial_person sp1 = new Serial_person(102, "sharma", "chirawa", "a.a.com", "nopwd");
            bfm.Serialize(fs, sp1);

            Console.WriteLine("Person details serialize");
            Console.ReadLine();


        }
    }
}

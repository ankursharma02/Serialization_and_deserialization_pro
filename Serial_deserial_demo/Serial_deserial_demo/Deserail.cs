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
    class Deserail
    {
        public static void main()
        {
            FileStream fs = new FileStream("e://serial_demo.txt", FileMode.Open);
            BinaryFormatter bfm = new BinaryFormatter();
            Serail_demo sr = (Serail_demo)bfm.Deserialize(fs);
            Console.WriteLine("std_id = " + sr.std_id);
            Console.WriteLine("std_name= " + sr.std_name);
            Console.ReadLine();


        }
    }
}

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
    class Serail_demo
    {
        
        public int std_id;
        public string std_name;
        public Serail_demo(int std_id, string std_name)
        {
            this.std_id = std_id;
            this.std_name = std_name;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("e://serial_demo.txt", FileMode.OpenOrCreate);
            BinaryFormatter bfm = new BinaryFormatter();
            Serail_demo sr = new Serail_demo(101, "ankur");
            bfm.Serialize(fs,sr);
            fs.Close();
            Console.WriteLine("Serialization completed");
            Console.ReadLine();
        }
    }
}

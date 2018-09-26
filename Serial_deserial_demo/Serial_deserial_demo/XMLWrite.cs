using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Serial_deserial_demo
{
   public class XMLWrite
    {
        static void Main(string[] args)
        {
            WriteXML();
        }

        public class Book
        {
            public String title;
        }

        public static void WriteXML()
        {
            Book overview = new Book();
            overview.title = "Serialization Overview";
            XmlSerializer writer = new XmlSerializer(typeof(Book));

            
            FileStream file = File.Create("e:/serialxmldemo.xml");

            writer.Serialize(file, overview);
            file.Close();
            Console.WriteLine("Xml serialization complete");
            Console.ReadLine();
        }
    }
}

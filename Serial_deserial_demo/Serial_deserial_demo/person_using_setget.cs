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
    class person_using_setget
    {
        int person_Id;
        string person_name;
        int age;
        double salary;
        public object this[int index]
        {
            get
            {
                if(index==1)
                    return person_Id;
                else if (index == 2)
                    return person_name;
                else if (index == 3)
                    return age;
                else if (index == 4)
                    return salary;
                else
                    return "";
            }
            set
            {
                if (index == 1)
                    person_Id = (int)value;
                else if (index == 2)
                    person_name = value.ToString();
                else if (index == 3)
                    age = (int)value;
                else if (index == 4)
                    salary = (double)value;

            }
            
        }
        person_using_setget(int person_Id, string person_name, int age, double salary)
        {
            this.person_Id = person_Id;
            this.person_name = person_name;
            this.age = age;
            this.salary = salary;

        }
        static void Main(string[] args)
        {
            person_using_setget ps = new person_using_setget(101,"adss",23,2222.22);
            person_using_setget ps1 = new person_using_setget(102, "Nk", 21, 222.22);

            person_using_setget ps2 = new person_using_setget(103, "ank", 22, 22222.22);
            FileStream fs = new FileStream("e://person1.txt", FileMode.OpenOrCreate);
            BinaryFormatter bfm = new BinaryFormatter();
            
            bfm.Serialize(fs, ps);
            bfm.Serialize(fs, ps1);
            bfm.Serialize(fs, ps2);
            fs.Close();
            Console.WriteLine("person details serailized");
            Console.ReadLine();
        }
    }
    

}

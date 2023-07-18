using System;
using System.Xml.Linq;

namespace StringArrayClass
{
	internal class Student
	{
        public string name;
        public string surname;
        public int age;
        public string address;


        public string GetFullName()
        {
            return name + " " + surname;
        }

    }

   

}


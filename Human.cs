using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                { 
                    _age = value; 
                }
                else
                { 
                    throw new AgeException("yas 0-dan boyuk olmalidir");
                }
            }
        }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
            
        }
    }
}


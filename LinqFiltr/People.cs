using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFiltr
{
    public class People
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public People()
        {

        }

        public People(string name , string surename, string email, int age)
        {
            Name = name;
            Surename = surename;    
            Email = email;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name - {Name}  Surename - {Surename}  Email - {Email}  Age - {Age}";
        }
    }
}

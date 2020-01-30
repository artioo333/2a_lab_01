using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    public class Person
    {
        public Person(int id, string name, string lastName, string phone)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Phone = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_lab
{
    class Human
    {
        public string name;
        public string surname;
        public int age;
        public int id;
        private Address _adress;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Id { get { return id; } set { id = value; } }
        public Address Adress { get { return _adress; } }


        public Human(string Name, string Surname, int Age, int Id, Address Adress)
        {
            name = Name;
            surname = Surname;
            age = Age;
            id = Id;
            _adress = Adress;
        }
    }
}

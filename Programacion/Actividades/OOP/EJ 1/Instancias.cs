using System;

namespace prueba
{
    public class Person
    {
        private string name, last_name;
        private int age;

        public string Name {  get { return name; } set { name = value; } }
        public string LastName { get { return last_name; } set { last_name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}

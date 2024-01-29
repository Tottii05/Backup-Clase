using System;

namespace Pruebas
{
    internal class Cat
    {
        private string name, breed, favFood;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public string Breed { get { return breed; } set { breed = value; } }
        public string FavFood { get {  return favFood; } set {  favFood = value; } }
        public int Age { get { return age; } set { age = value; } }

        public void MakeSound () { Console.WriteLine("Meow"); }
        public void Play () { Console.WriteLine("*Shes playing"); }
        public void Wash() { Console.WriteLine("*Shes washing herself"); }
        public void Eat() { Console.WriteLine("*Shes eating"); }
        public void Hount() { Console.WriteLine("*Shes hounting, will she get something?"); }
    }
}

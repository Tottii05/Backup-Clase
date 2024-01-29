using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Cat cat = new Cat();
            cat.Name = "Milka";
            cat.Breed = "Siamese";
            cat.FavFood = "Salmon";
            cat.Age = 3;
            
            Console.WriteLine(cat.Name + " " + cat.Breed + " " + cat.FavFood + " " + cat.Age);
            cat.MakeSound();
            cat.Play();
            cat.Wash();
            cat.Eat();
            cat.Hount();
        }
    }
}
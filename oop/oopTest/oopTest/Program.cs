using System;


namespace oopTest
{
    public class Person
    {
        public string Name = "Göran";
        public int age = 29;
        public bool hasPet = false;

        public void Greeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and my age is " + age);
        }
    }

   


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Gustav",
                age = 2,
                hasPet = false
            };
            person.Greeting();

            Person person2 = new Person();
            Console.WriteLine(person2.age);

            Animal Dog = new Animal
            {
                legs = 4,
                sound = "bark",
                age = 2,
                color = "brown"
            };
            Dog.MakeSound();

            Animal Centipede = new Animal
            {
                legs = 1000,
                sound = " ",
                age = 0,
                color = "red"
            };
            Centipede.MakeSound();

            Animal anomolocaris = new Animal
            {
                legs = 0,
                sound = "Otherwordly screams",
                age = 1,
                color = "gray"
            };
            anomolocaris.MakeSound();

            Dog.IsAnimal = "no";
            Console.WriteLine(Dog.IsAnimal);
        }
    }
}

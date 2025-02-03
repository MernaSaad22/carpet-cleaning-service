namespace challeng1
{
    //polymophrism
    class Animal
    {
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public Pig(string name, int age, double size)
            : base(name, age)
        {
            {
                Size = size;
            }
        }
        public double Size { get; set; }


        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("cat",3);     // Create a Animal object
            Animal myPig = new Pig("pig",5,500);           // Create a Pig object
            Animal myDog = new Dog("dog",6);           // Create a Dog object
            myAnimal.AnimalSound(); // The animal makes a sound
            myPig.AnimalSound();    // The pig says: wee wee
            myDog.AnimalSound();    // The dog says: bow wow
        }
    }
}

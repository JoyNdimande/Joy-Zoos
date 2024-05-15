using System;


namespace Zoo_Management
{
    public abstract class AnimalTracking
    {
        public string Classification { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Location { get; set; }

        // Base class constructor
        public AnimalTracking(string classification, string name, int age, double weight, string location)
        {
            Classification = classification;
            Name = name;
            Age = age;
            Weight = weight;
            Location = location;
        }

        // Abstract method for displaying information
        public abstract void DisplayInfo();

        // Abstract methods for animal behaviors
        public abstract void Feed();
        public abstract void MakeSound();
        public abstract void Move();
    }

    // Derived class for Elephant
    public class Elephant : AnimalTracking
    {
        public Elephant(string name, int age, double weight, string location) : base("Elephant", name, age, weight, location) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Classification: Elephant");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Location: {Location}");
        }

        public override void Feed()
        {
            Console.WriteLine($"Feeding {Name} the elephant...");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the elephant is trumpeting...");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the elephant is walking...");
        }
    }

    // Derived class for Shark
    public class Shark : AnimalTracking
    {
        public Shark(string name, int age, double weight, string location) : base("Shark", name, age, weight, location) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Classification: Shark");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Location: {Location}");
        }

        public override void Feed()
        {
            Console.WriteLine($"Feeding {Name} the shark...");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the shark is making noise...");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the shark is swimming...");
        }
    }

    // Derived class for Buffalo
    public class Buffalo : AnimalTracking
    {
        public Buffalo(string name, int age, double weight, string location) : base("Buffalo", name, age, weight, location) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Classification: Buffalo");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Location: {Location}");
        }

        public override void Feed()
        {
            Console.WriteLine($"Feeding {Name} the buffalo...");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the buffalo is making sound...");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the buffalo is moving...");
        }
    }

    // Derived class for Godzilla
    public class Godzilla : AnimalTracking
    {
        public Godzilla(string name, int age, double weight, string location) : base("Godzilla", name, age, weight, location) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Classification: Godzilla");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Location: {Location}");
        }

        public override void Feed()
        {
            Console.WriteLine($"Feeding {Name} the godzilla...");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the godzilla is roaring...");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the godzilla is stomping...");
        }
    }
}

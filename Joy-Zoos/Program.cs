using System;
using System.Collections.Generic;



namespace ZooManagementApp
{
    public class InvalidFoodException : Exception
    {
        public InvalidFoodException(string message) : base(message)
        {
            Console.WriteLine("Animal cannot eat that");
        }
    }

    public class ZooMapException : Exception
    {
        public ZooMapException(string message) : base(message)
        {
            Console.WriteLine();
        }
    }

    // Enum for classifying types of animals
    public enum AnimalType
    {
        Mammal,
        Bird,
        Fish
    }

    // Enum for classifying types of food
    public enum FoodType
    {
        Meat,
        Vegetation,
        Mixed
    }

    // Enum for classifying types of habitats
    public enum HabitatType
    {
        Forest,
        Aquatic,
        Grassland
    }

    // Struct for storing dietary information and feeding schedules
    public struct DietInfo
    {
        public readonly FoodType PreferredFood;
        public readonly string FeedingSchedule;

        // Constructor to initialize the struct
        public DietInfo(FoodType preferredFood, string feedingSchedule)
        {
            PreferredFood = preferredFood;
            FeedingSchedule = feedingSchedule;
        }
    }

    public interface IClimbable
    {
        void Climb();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    // Abstract class representing general animal behaviors
    public abstract class Animal
    {
        private string _name;
        private int _age;
        private double _weight;
        private string _habitat;
        private DietInfo _dietInfo;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Habitat
        {
            get { return _habitat; }
            set { _habitat = value; }
        }

        public DietInfo DietInformation // DietInfo property
        {
            get { return _dietInfo; }
            set { _dietInfo = value; }
        }

        // Abstract methods to be implemented by derived classes
        public abstract void Eat(FoodType food);
        public abstract void Move();
        public abstract void MakeSound();
        public abstract void DisplayInfo();
    }

    // Derived class representing a specific animal
    public class Elephant : Animal, IClimbable
    {
        // Constructor
        public Elephant()
        {
            DietInformation = new DietInfo(FoodType.Vegetation, "Twice a day");
        }

        // Implement methods of the IClimbable interface
        public void Climb()
        {
            Console.WriteLine("Elephant is climbing...");
        }

        // Implement methods inherited from the Animal class
        public override void Eat(FoodType food)
        {
            if (food != FoodType.Vegetation)
            {
                throw new InvalidFoodException("Elephant can only eat vegetation.");
            }

            Console.WriteLine("Elephant is eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Elephant is moving...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Elephant is trumpeting...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}, Habitat: {Habitat}");
        }
    }

    // Derived class representing a specific animal
    public class Shark : Animal, ISwimmable
    {
        // Constructor
        public Shark()
        {
            DietInformation = new DietInfo(FoodType.Meat, "Once a day");
        }

        // Implement methods of the ISwimmable interface
        public void Swim()
        {
            Console.WriteLine("Shark is swimming...");
        }

        // Implement methods inherited from the Animal class
        public override void Eat(FoodType food)
        {
            if (food != FoodType.Meat)
            {
                throw new InvalidFoodException("Shark can only eat meat.");
            }
            Console.WriteLine("Shark is eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Shark is swimming...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Shark is making sound...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}, Habitat: {Habitat}");
        }
    }

    // Derived class representing a specific animal
    public class Buffalo : Animal
    {
        // Constructor
        public Buffalo()
        {
            DietInformation = new DietInfo(FoodType.Vegetation, "Three times a day");
        }

        // Implement methods inherited from the Animal class
        public override void Eat(FoodType food)
        {
            Console.WriteLine("Buffalo is eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Buffalo is moving...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Buffalo is making sound...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}, Habitat: {Habitat}");
        }
    }

    // Derived class representing a specific animal
    public class Godzilla : Animal, IClimbable, ISwimmable
    {
        // Constructor
        public Godzilla()
        {
            DietInformation = new DietInfo(FoodType.Mixed, "One huge Lion a day");
        }

        // Implement methods of the IClimbable interface
        public void Climb()
        {
            Console.WriteLine("Godzilla is climbing...");
        }

        // Implement methods of the ISwimmable interface
        public void Swim()
        {
            Console.WriteLine("Godzilla is swimming...");
        }

        // Implement methods inherited from the Animal class
        public override void Eat(FoodType food)
        {
            Console.WriteLine("Godzilla is eating...");
        }

        public override void Move()
        {
            Console.WriteLine("Godzilla is moving...");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Godzilla is making sound...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}, Habitat: {Habitat}");
        }
    }

    namespace ZooManagementApp.Menu
    {
        public class Menu
        {
            public static void Display()
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine();
                Console.WriteLine("1. Animals that can be seen in JOY Zoo");
                Console.WriteLine("2. Add Animal");
                Console.WriteLine("3. Track");
                Console.WriteLine("4. Interaction");
                Console.WriteLine("5. Show Food Schedule");
                Console.WriteLine("6. Exit");
            }

            public static void ProcessOption(int option)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You selected option 1");
                        AvailableAnimals();
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2.");
                        GetAnimalInformation();
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3.");
                        AnimalTracking();
                        break;
                    case 4:
                        Console.WriteLine("You selected Option 4.");
                        AnimalInteraction();
                        break;
                    case 5:
                        Console.WriteLine("You selected Option 5.");
                        ShowFoodSchedule();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }

            // Method to display available animals
            static void AvailableAnimals()
            {
                Console.WriteLine("These are the animals you'll find in JOY ZOO");
                // Array of Available Animals
                string[] animals = {
                "Elephant",
                "Shark",
                "Buffalo",
                "Godzilla"
            };

                Console.WriteLine();
                foreach (string animal in animals)
                {
                    Console.WriteLine(animal);
                }
            }

            // Method to get information about a new animal
            static void GetAnimalInformation()
            {
                Console.WriteLine("What is the animal's classification :");
                string classification = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Name of animal : ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Age  : ");
                string age = Console.ReadLine();
                Console.WriteLine();

                // Validate weight input
                double weight;
                bool validWeight = false;
                do
                {
                    Console.WriteLine("Weight of the animal :");
                    string weightInput = Console.ReadLine();
                    Console.WriteLine();

                    // Try parsing the input into a double
                    if (double.TryParse(weightInput, out weight))
                    {
                        // Checking if the weight is within acceptable range 
                        if (weight >= 0 && weight <= 10000)
                        {
                            validWeight = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid weight. Weight must be between 0 and 10000.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid numeric weight.");
                    }
                } while (!validWeight);

                Console.WriteLine("Habitat (Place where animal makes home)  :");
                string habitat = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Animal added successfully, " + name + " is part of the JOY ZOO");
                Console.WriteLine("THANK YOU <3.");
            }

            // Method to track animals
            private static void AnimalTracking()
            {
                Console.WriteLine("Location of all animals in JOY ZOO");
                // Create a list to hold animals
                List<Animal> animals = new List<Animal>();

                // Add animals to the list
                animals.Add(new Elephant() { Name = "Filly", Age = 24, Weight = 4000, Habitat = "Zoo Forest" });
                animals.Add(new Shark() { Name = "Killer", Age = 17, Weight = 105, Habitat = "Aquaria" });
                animals.Add(new Buffalo() { Name = "Cyril", Age = 67, Weight = 78, Habitat = "Besides Entrance 1" });
                animals.Add(new Godzilla() { Name = "Goerge", Age = 1532, Weight = 8000, Habitat = "Zoo Forest" });

                // Display information of all animals
                Console.WriteLine();
                foreach (var animal in animals)
                {
                    animal.DisplayInfo();
                    Console.WriteLine();
                }
            }

            // Method for animal interaction
            private static void AnimalInteraction()
            {
                Console.WriteLine("Interacting with animals in JOY ZOO");

                // Create instances of animals and interact with them
                Elephant elephant = new Elephant() { Name = "Filly", Age = 24, Weight = 4000, Habitat = "Zoo Forest" };
                Shark shark = new Shark() { Name = "Killer", Age = 17, Weight = 105, Habitat = "Aquaria" };
                Buffalo buffalo = new Buffalo() { Name = "Cyril", Age = 67, Weight = 78, Habitat = "Besides Entrance 1" };
                Godzilla godzilla = new Godzilla() { Name = "Goerge", Age = 1532, Weight = 8000, Habitat = "Zoo Forest" };

                // Interact with each animal
                Console.WriteLine();
                Console.WriteLine("Interacting with elephant:");
                elephant.DisplayInfo();
                elephant.Eat(FoodType.Vegetation);
                elephant.Move();
                elephant.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with shark:");
                shark.DisplayInfo();
                shark.Eat(FoodType.Meat);
                shark.Move();
                shark.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with buffalo:");
                buffalo.DisplayInfo();
                buffalo.Eat(FoodType.Vegetation);
                buffalo.Move();
                buffalo.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with godzilla:");
                godzilla.DisplayInfo();
                godzilla.Eat(FoodType.Mixed);
                godzilla.Move();
                godzilla.MakeSound();
            }

            // Method to show the food schedule for each animal
            public static void ShowFoodSchedule()
            {
                Console.WriteLine("Feeding schedule for animals in JOY ZOO");

                // Create a list to hold animals
                List<Animal> animals = new List<Animal>();

                // Add animals to the list
                animals.Add(new Elephant() { Name = "Filly", Age = 24, Weight = 4000, Habitat = "Zoo Forest" });
                animals.Add(new Shark() { Name = "Killer", Age = 17, Weight = 105, Habitat = "Aquaria" });
                animals.Add(new Buffalo() { Name = "Cyril", Age = 67, Weight = 78, Habitat = "Besides Entrance 1" });
                animals.Add(new Godzilla() { Name = "Goerge", Age = 1532, Weight = 8000, Habitat = "Zoo Forest" });

                // Display feeding schedule of all animals
                Console.WriteLine();
                foreach (var animal in animals)
                {
                    Console.WriteLine($"{animal.Name} - Feeding Schedule: {animal.DietInformation.FeedingSchedule}");
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JOY ZOO Management APP <3");
            Console.WriteLine("THE GREATNESS OF A NATION CAN BE JUDGED BY THE WAY ITS ANIMALS ARE TREATED");
            Console.WriteLine();

            // Display options
            ZooManagementApp.Menu.Menu.Display();

            // Read user input
            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please enter a valid number.");
                return;
            }

            // Perform based on selected option
            ZooManagementApp.Menu.Menu.ProcessOption(option);
        }
    }
}
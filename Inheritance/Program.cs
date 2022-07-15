using System; 
using Inheritance; 

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird()
            {
                Age = 1,
                Breed = "Penguin",
                Sex = "female",
                Color = "black and white",

                Fly = false,
                Edible = false,
                Name = "Penguina",
                Description = "small and cute",

            };


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             
        
             * Creatively display the class member values 
             */
            Console.WriteLine("****BIRD IS THE WORD****");
            Console.WriteLine($"My {bird1.Breed} is {bird1.Sex} and her name is {bird1.Name}. She is {bird1.Color} and is {bird1.Description}.");
            Console.WriteLine($"Can {bird1.Name} fly you ask? {bird1.Fly}. However, she slides around the ice swiftly!");
            Console.WriteLine($"Can you eat {bird1.Breed}s? {bird1.Edible}. I don't think {bird1.Breed}s are tasty!");
            Console.WriteLine("---------------\n");

            var reptile1 = new Reptile()
            {
                Age = 15,
                Breed = "Alligator",
                Sex = "male",
                Color = "swamp green",

                Scales = true,
                Carnivore = true,
                ClawType = "pointy and sharp",
                SkinType = "scaly and thick",
            };

            Console.WriteLine("****REPTILE STORIES FOR KIDS****");
            Console.WriteLine($"Ah! I was fishing in my lake behind my house and saw an {reptile1.Breed}! My neighbors told me he is {reptile1.Sex} and is {reptile1.Age} years old. " +
                $"He is a gross {reptile1.Color}, and has {reptile1.ClawType} claws and his skin was {reptile1.SkinType}! I hope to see this fascinating {reptile1.Breed} again!");
            Console.WriteLine($"Did he have scales you ask? {reptile1.Scales}");
            Console.WriteLine($"Does he eat other fish in the lake? {reptile1.Carnivore}");
            Console.WriteLine("But what can you do! Mother nature has her ways.");
            Console.WriteLine("---------------\n");
        }
    }
}

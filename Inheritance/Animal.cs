using System;
using System.Collections.Generic;
using System.Text;

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

/*Create an object of your Reptile class
 *  give values to your members using the object of your Reptile class
 *  
 * Creatively display the class member values 
 */

namespace Inheritance
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Breed { get; set; }   
        public string Sex { get; set; } 
        public string Color { get; set; }   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store.Pets // here for organization + specification; namespaces follow folder structure; idiomatic to keep folders + namespaces aligned
{ // blue keywords are keywords in C# law; green are static
    class Dog // implicitly internal
    {
        public string Size { get; set; }
        public short Weight { get; private set; }
        public string Name { get; set; }

        // constructor/constructor method - return type + name are the same
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size; // looking at things owned by the class - capitalized names; camelCase denotes parameters
        }

        // behavior = methods - similar to JS functions
        // Method signature is the way a method is defined = access modifier + return type + name + parameters
        public void Bark()
        {
            Console.WriteLine($"{Name}");
        }

        public void Eat(string typeOfFood)
        {
            if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase))
            // if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }
            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}");
        }
    }
}
// CLASS => behavior = method; statefulness = properties; internal stuff = fields
// property => access modifier (public or private) + kind of data (type) + name of property (PascalCasing)
// public means EVERYBODY can see it
// {get; set;} is an "auto-property"
// can't declare variables at class-level; only inside methods
// class level - you can only define methods, properties + fields
// class is the shape of a thing; we can create new instances that are real and able to be manipulated
// don't need to use all properties in an instance, but we can't add new properties to an instance - no dynamic adding or re-typing or anything
// default values = starting values (numbers are 0, strings are undefined, booleans are false)
// null in C# = undefined in JS
// private access = only things in this class can use it; cannot use outside of the class. - this is the default/implicit access modifier
// internal access = anything in this project // useful for creating dev tools
// protected access = anything that inherits from me can access
// void = "I'm not returning anything" return type
// parameters in C# = must define what type it is
// "static" members are shared across all instances of a class; can no longer access instance methods

// Properties = there are rules for the way data should be accessed
// we can give public properties private setters so that the value cannot be freely modified

// constructor functions = default, returns new instance of the class
// we can specify that, when someone wants to create a new class instance, they must provide some base information

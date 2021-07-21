using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store.Pets
{
    class Bear
    {
        // properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfFish { get; set; }
        public string EducationLevel { get; set; }
        public Tiger BestTigerFriend { get; set; }
        public bool LovesHoney { get; set; }

        // constructors
        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED"; // default value

            if (name == "Winnie the Pooh")
            {
                LovesHoney = true;
            }
            else if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }
    }
}

// remove "set" to make it read-only; after thing is created, that property is immutable.
// Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read. 
// function that exists on a class
// every method is a function, but every function is not a method.

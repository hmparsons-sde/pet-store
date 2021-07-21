
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store.Pets
{
    class Tiger
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }

        int _numberOfBites;
        public Tiger()
        {
            _numberOfBites = 1;
        }

        public void Bite(string handlerName)
        {
            _numberOfBites++;
            if (_numberOfBites > 5)
            {
                Console.WriteLine("This is a bitey Tiger");
            }

            Console.WriteLine($"{Name} the tiger just bit {handlerName}.");
        }
    }
}

// fields = what we want to track in a class, but not share publicly.
// fields are implicitly private.
// field names are prefixed with an underscore and camelCased. Idiomatic, not law.
// think of a field as a class-level variable.
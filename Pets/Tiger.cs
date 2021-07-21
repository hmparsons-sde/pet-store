using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store.Pets // each class has its own file
{
    class Tiger
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int BodyCount { get; set; }
        public short Speed { get; set; }

        //fields = implicitly private
        private int _numberOfChomps;

        public void Bite(string handlerName)
        {
            _numberOfChomps++;
            Console.WriteLine($"{Name} ate {handlerName}. That's the {_numberOfChomps} time!");
        }
    }
}

// fields = what we want to track in a class, but not share publicly.
// field names are prefixed with an underscore and camelCased. Idiomatic, not law.
// think of a field as a class-level variable.
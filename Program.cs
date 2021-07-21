using System; // order doesn't matter
using pet_store.Pets;

namespace pet_store
{
    class Program
    {
        static void Main(string[] args)
        {
            var melba = new Dog("Melba", 60, "Medium");
            melba.Bark();
            //object initializer; idiomatic to C#
            var tiger = new Tiger
            {
                Name = "Kisa",
                BodyCount = 20,
                Size = "Medium"
            };
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
        }
    }
}

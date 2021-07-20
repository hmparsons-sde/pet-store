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
        }
    }
}

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

            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();

            melba.Eat(typeOfFoodForMelba);
            var barley = new Dog("Barley", 50, "Medium");
            barley.Bark();

            barley.Eat("table scraps");
            //object initializer; idiomatic to C#
            var tiger = new Tiger
            {
                Name = "Kisa",
                NumberOfKills = 0,
                Size = "Medium"
            };

            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");
            tiger.Bite("Chris");

            var bear = new Bear("Yogi", "Brown");
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(5);
            bear.EatFish(-5);

            //passing an object reference to a property
            bear.BestTigerFriend = new Tiger { Name = "Bob", Size = "Miniature" }; //object initializer

            bear.HangOutWithBestFriend();

            Console.WriteLine(bear.BestTigerFriend.Name);
        }
    }
}

using System;

namespace sample13
{
    class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler = new Traveler();
            traveler.Name = "Lalo";
            traveler.LastPlaceToVisit =  ( WondersOfTheAncientWorld) 2; // WondersOfTheAncientWorld.GreatPyramidOfGiza;
            traveler.NexPlaceToVisit =( WondersOfTheAncientWorld) 4; // WondersOfTheAncientWorld.ColossusOfRhodes;

            traveler.BucketList = (NewWonders) 9; // NewWonders.ChichenItzaPyramid | NewWonders.AreciboObservatory | NewWonders.MarianFosa;

            Console.WriteLine($"{traveler.LastPlaceToVisit}");

            Console.WriteLine ($"{traveler.BucketList }");
            
        }


    }
}

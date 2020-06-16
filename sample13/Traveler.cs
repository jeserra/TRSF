using System;

namespace sample13 {

    public class Traveler 
    {

        public string Name { get;set;}
        public WondersOfTheAncientWorld NexPlaceToVisit {get;set;}
        public WondersOfTheAncientWorld LastPlaceToVisit {get;set;}

        public NewWonders BucketList {get;set;}
    }
}
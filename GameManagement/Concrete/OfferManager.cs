using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    class OfferManager : IOfferService
    {
        public void AddOffer(Offer offer)
        {
            Console.WriteLine("Offer added");
        }

       

        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine("Offer deleted");
        }

       

        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine("Offer updated");
        }

        
    }
}

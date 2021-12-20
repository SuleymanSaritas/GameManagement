using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
   public interface IOfferService
    {
        public void AddOffer(Offer offer);
        public void UpdateOffer(Offer offer);
        public void DeleteOffer(Offer offer);
    }
}

using GameManagement.Abstract;
using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Concrete
{
    class SalesManager : ISalesService

    {
        public void sale(Gamer gamer,Offer offer)
        {
            Console.WriteLine("Sale is completed thank you "+gamer.Firstname);
            Console.WriteLine(offer.Name+"Offer applied");
            Console.WriteLine(gamer.Firstname+" You used "+offer.Name 
                +" offer "+" You saved %"+offer.percentage+" of your money");

        }
    }
}

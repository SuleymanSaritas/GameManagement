using GameManagement.Entities;
using GameManagement.Concrete;
using GameManagement.Adapter;
using GameManagement.Abstract;

using System;

namespace GameManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {
                DateOfBirth = new DateTime(2000,09,13),
                Firstname = "Süleyman",
                Lastname = "Sarıtaş",
                NationalityId = 10885138262
            };
            Offer offer = new Offer()
            {
                DateOfFinish = new DateTime(2022, 01, 01),
                Name = " Christmas Offer",
                percentage = 50
            };
            BaseGamerManager gamerManager = new GamerManager(new MernisAdapter());
            gamerManager.save(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.sale(gamer, offer);

            
        }
    }
}

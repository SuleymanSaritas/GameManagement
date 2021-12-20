using System;
using System.Collections.Generic;
using System.Text;
using GameManagement.Entities;

namespace GameManagement.Abstract
{
   public abstract class BaseGamerManager
    {
        public virtual void save(Gamer gamer) 
        {
            Console.WriteLine("Saved to db : " + gamer.Firstname);
        }
        public virtual void update(Gamer gamer) 
        {
            Console.WriteLine("Updated to db : " + gamer.Firstname);
        }
        public virtual void delete(Gamer gamer)
        {
            Console.WriteLine("Deleted from db : " + gamer.Firstname);
        }
       

    }
}

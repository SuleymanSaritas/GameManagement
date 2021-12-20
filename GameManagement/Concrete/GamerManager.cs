using System;
using System.Collections.Generic;
using System.Text;
using GameManagement.Abstract;
using GameManagement.Entities;
namespace GameManagement.Concrete
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

      
        public GamerManager (IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService; 
        }

        public override void save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfItsReal(gamer))
            {
                base.save(gamer);
            }
            else
            {
                throw new Exception("Not a valid Gamer");
            }
           
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GameManagement.Abstract;
using GameManagement.Entities;

namespace GameManagement.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfItsReal(Gamer gamer)
        {
            return true; 
        }
    }
}

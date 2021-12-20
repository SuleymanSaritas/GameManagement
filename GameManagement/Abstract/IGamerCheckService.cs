using GameManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagement.Abstract
{
    interface IGamerCheckService
    {
        public bool CheckIfItsReal(Gamer gamer);
    }
}

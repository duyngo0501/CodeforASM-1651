using System;
using System.Collections.Generic;
using System.Text;

namespace Gamingmanagement
{
    public class Strategy : Game, IGame
    {
        public int GetGameID()
        {
            return Gameid;
        }
        public string GetGameStatus()
        {
            return Gamestatus;
        }
        public string GetGameType()
        {
            return "Strategy";
        }
    }
}

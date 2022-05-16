using System;
using System.Collections.Generic;
using System.Text;

namespace Gamingmanagement
{
    public class GameFactory
    {
        public static Game GetGame(string gametype)
        {
            Game gamedetail = null;
            switch (gametype)
            {
                case "Action":
                    gamedetail = new Action();
                    break;
                case "Horror":
                    gamedetail = new Horror();
                    break;
                case "Strategy":
                    gamedetail = new Strategy();
                    break;
                default:
                    gamedetail = new Action();
                    break;
            }
            return gamedetail;
        }
        
    }
}

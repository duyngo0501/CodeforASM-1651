using System;
using System.Collections.Generic;
using System.Text;

namespace Gamingmanagement
{
    public interface IGame
    {
        string GetGameType();
        int GetGameID();
        string GetGameStatus();
    }
}

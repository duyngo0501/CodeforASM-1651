using System;
using System.Collections.Generic;
using System.Text;

namespace Gamingmanagement
{
    public abstract class Game
    {
        public string Gametype { get; set; }
        public string Gamename { get; set; }
        public int Gameid { get; set; }
        public string Gamestatus { get; set; }
        public Game()
        {

        }
        public Game(string gametype,string gamename,int gameid,string gamestatus)
        {
            Gametype = gametype;
            Gamename = gamename;
            Gameid = gameid;
            Gamestatus = gamestatus;
        }
        public virtual void InputInfo(string gametype)
        {
            try
            {
                Gametype = gametype;
                Console.WriteLine("Input name of game: ");
                Gamename = Console.ReadLine();
                Console.WriteLine("Input ID of game: ");
                Gameid = int.Parse(Console.ReadLine());
                Console.WriteLine("Input status for game: ");
                Gamestatus = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("- Type: " + Gametype);
            Console.WriteLine("- Name: " + Gamename);
            Console.WriteLine("- ID: " + Gameid);
            Console.WriteLine("- Status: " + Gamestatus);
        }
    }
}

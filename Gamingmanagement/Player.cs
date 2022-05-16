using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Gamingmanagement
{
    public class Player
    {
        //Properties
        private static ArrayList playerList = new ArrayList();
        public string Playername { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Role { get; set; }
        //Constructors
        public Player()
        {

        }
        public Player(string playername, string username, string userpassword, string role)
        {
            Playername = playername;
            Username = username;
            Userpassword = userpassword;
            Role = role;
        }
    }
}

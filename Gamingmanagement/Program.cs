using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Collections;

namespace Gamingmanagement
{
    class Program
    {

        private static ArrayList playerList = new ArrayList();
        private List<Player> list;
        static void Main(string[] args)
        {
            //Player player1 = new Player("Duy", "duyngo", "123456", "player");
            //Player player2 = new Player("Thuan", "thuan123", "0501", "player");
            //Player player3 = new Player("Tien", "tien123", "0502", "player");
            //Player staff = new Player("Staff", "staff", "2707", "staff");
            //playerList.Add(player1);
            //playerList.Add(player2);
            //playerList.Add(player3);
            //playerList.Add(staff);

            //Player loggedInPlayer = null;
            //String userName = "";
            //string password = "";
            //while (true)
            //{
            //    if (loggedInPlayer == null)
            //    {
            //        Console.WriteLine("Please login");
            //        Console.WriteLine("Username");
            //        userName = Console.ReadLine();
            //        Console.WriteLine("Password");
            //        password = Console.ReadLine();
            //        loggedInPlayer = checkLogin(userName, password);
            //    }
            //}

            StaffManagement manage = new StaffManagement();

            {
                int option = 0;
                bool check = false;
                do
                {
                    option = manage.Menu();
                    switch (option)
                    {
                        case 1:
                            Console.Write("Input the type of game(Action/Horror/Strategy): ");
                            string gametype = Console.ReadLine();
                            manage.AddGame(gametype);
                            break;
                        case 2:
                            manage.ShowAllGame();
                            break;
                        case 3:
                            manage.ShowActionGame();
                            break;
                        case 4:
                            manage.ShowHorrorGame();
                            break;
                        case 5:
                            manage.ShowStrategyGame();
                            break;
                        case 6:
                            int ops = 0;
                                ops = manage.MenuSearch();
                                switch (ops)
                                {
                                    case 1:
                                        Console.WriteLine("Input the name of the game you want to search: ");
                                        string gamename = Console.ReadLine();
                                        manage.SearchGameByName(gamename);
                                        break;
                                    case 2:
                                        Console.WriteLine("Input the ID of the game you want to search: ");
                                        int gameid = int.Parse(Console.ReadLine());
                                        manage.SearchGameById(gameid);
                                        break;
                                    default:
                                        Console.WriteLine("Wrong input!!!");
                                        break;
                                }
                                break;
                        case 7:
                            Console.WriteLine("Input name of the game to want to delete: ");
                            string name = Console.ReadLine();
                            manage.DeleteByName(name);
                            break;
                        case 8:
                            Console.WriteLine("Input the name of the game you want to update: ");
                            name = Console.ReadLine();
                            manage.UpdateGameByName(name);
                            break;
                        case 9:
                            Console.WriteLine("Exit successful !!!");
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Wrong input !!!!");
                            break;
                    }
                } while (check == false);
            }
        }
 
        public static Player checkLogin(string username, string userpassword)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                Player pl = (Player)playerList[i];
                if (pl.Username.Equals(username.ToLower()) && pl.Userpassword.Equals(userpassword))
                {
                    return pl;
                }
            }
            return null;
        }
    }
}

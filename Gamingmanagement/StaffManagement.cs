using System;
using System.Collections.Generic;
using System.Text;

namespace Gamingmanagement
{
    class StaffManagement
    {
        private List<Game> list;
        public StaffManagement()
        {
            list = new List<Game>();
        }
        public void AddGame(string gametype)
        {
            Game g = GameFactory.GetGame(gametype);
            g.InputInfo(gametype);
            list.Add(g);
        }
        public void ShowAllGame()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("There is no game in here!!!");
            }
            else
            {
                foreach (var s in list)
                {
                    s.ShowInfo();
                }
            }
        }
        public void ShowActionGame()
        {
            if( list.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please add the game !!!");
            }
            else
            {

                foreach (var a in list)
                {
                    if (a is Action)
                    {
                        a.ShowInfo();
                    }
                }
            }
           
        }
        public void ShowHorrorGame()
        {
            if ( list.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please add the game !!!");
            }
            else
            {
                foreach (var h in list)
                {
                    if (h is Horror)
                    {
                        h.ShowInfo();
                    }
                }

            }
            
        }
        public void ShowStrategyGame()
        {
            if (list.Count == 0)
            {
                Console.WriteLine('\n');
                Console.WriteLine("Please add the game ");
            }
            else
            {

                foreach (var s in list)
                {
                    if (s is Strategy)
                    {
                        s.ShowInfo();
                    }
                }
            }  
        }
        public void SearchGameByName(string gamename)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Wrong name of the game or the ID");
                Console.WriteLine("Please try it again!!!");

            }
            else
            {

                foreach (var s in list)
                {
                    if (gamename == s.Gamename)
                    {
                        s.ShowInfo();
                    }
                }
            }

        }

        public void SearchGameById(int gameid)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Wrong ID of the game");
                Console.WriteLine("Please try it again!!!");
            }
            else
            {
                foreach (var s in list)
                {
                    if (gameid == s.Gameid)
                    {
                        s.ShowInfo();
                    }
                }
            }
        }
        public void DeleteByName(string gamename)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Wrong name of the game to delete");
                Console.WriteLine("Please try it again!!!");
            }
            else
            {
                foreach (var d in list)
                {
                    if (gamename == d.Gamename)
                    {
                        list.Remove(d);
                        return;
                    }
                }
            }
        }
        public void UpdateGameByName(string gamename)
        {
            foreach (var u in list)
            {
                if (u.Gamename == gamename)
                {
                    if (u is Action)
                    {
                        Action a = u as Action;
                        try
                        {
                            Console.WriteLine("Input type of game: ");
                            a.Gametype = Console.ReadLine();
                            Console.WriteLine("Input ID of game: ");
                            a.Gameid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input status for game: ");
                            a.Gamestatus = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    else if (u is Horror)
                    {
                        Horror h = u as Horror;
                        try
                        {
                            Console.WriteLine("Input type of game: ");
                            h.Gametype = Console.ReadLine();
                            Console.WriteLine("Input ID of game: ");
                            h.Gameid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input status for game: ");
                            h.Gamestatus = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }

                    }
                    else
                    {
                        Strategy s = u as Strategy;
                        try
                        {
                            Console.WriteLine("Input type of game: ");
                            s.Gametype = Console.ReadLine();
                            Console.WriteLine("Input ID of game: ");
                            s.Gameid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input status for game: ");
                            s.Gamestatus = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                }
            }
        }
        public int Menu()
        {
            int option = 0;
            Console.WriteLine("\n1. Add new game\n2. Show all game\n3. Show Action game\n4. Show Horror game\n5. Show Strategy game\n6. Search the game\n7. Delete the game by name\n8. Update game by name\n9. Exit");
            Console.Write("Please enter your choice: \n");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public int MenuSearch()
        {
            int op = 0;
            Console.WriteLine("1.Search game by name\n2.Search game by ID");
            Console.Write("Enter your choice to search the game: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}

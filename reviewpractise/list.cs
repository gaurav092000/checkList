using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewpractise
{
    internal class list
    {
        //pass of object in list

        static void Main()
        {
            List<player> players = new List<player>();

           player player=new player("Gaurav");
            player player1 = new player("Ramesh");
            player player2 = new player("Rajesh");

            players.Add(player);
            players.Add(player1);
                players.Add(player2);
            foreach (var item in players)
            {
                Console.WriteLine(item.username);
            }
            Console.WriteLine("------------------------------");
            players[2].username="umesh";
            players[1].username = "Mahesh";

            foreach (var item in players)
            {
                Console.WriteLine(item.username);
            }
            Console.WriteLine("-----------------------------------------");
            var items = players.OrderBy(x => x.username);
            foreach(var name in items)
            {
                Console.WriteLine(name.username);
            }

            Console.ReadLine();
        }
    }
    class player
    {
        public string username;

        public player(string username)
        {
            this.username= username;                                 
        }
    }
}

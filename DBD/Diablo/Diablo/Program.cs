using Diablo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //List<Game> games = GetAllUserGames();
            //Console.WriteLine(games.Count());
            //Thread.Sleep(5000);
            //Console.WriteLine(string.Join(Environment.NewLine, games.Select(g=>g.Name)));

            Console.Write("Write UserName:...");
            var uname = Console.ReadLine();

            var u_games = GetAllGamesOfUser(uname);
            Console.WriteLine(u_games.Count);
            foreach (var game in u_games)
            {
                Console.WriteLine($"Game {game.Name} with duration {game.Duration} hours.");
                Thread.Sleep(2000);                
            }

        }
        //Nakov
        public static List<Game> GetAllGamesOfUser(string username)
        {
            using (var context = new DiabloContext())
            {
                int userIdFd = context.Users.FirstOrDefault(u => u.Username.ToLower()==username.ToLower()).Id;
                int[] userGameIds = context.UsersGames.Where(ug => ug.UserId == userIdFd).Select(ug=>ug.Id).ToArray();
                return context.Games.Where(g => userGameIds.Contains(g.Id)).ToList();                       
            }
        }

        public static List<Game> GetAllUserGames()
        {
            var context = new DiabloContext();
            var result = context.Games.ToList();
            context.Dispose();
            return result;
        }
    }
}
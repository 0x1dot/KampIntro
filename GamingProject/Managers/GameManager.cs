using System;
using GamingProject.Entitity;

namespace GamingProject
{
    internal class GameManager : IGamerService
    {
        public void Add(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game updated.");
        }
    }
}

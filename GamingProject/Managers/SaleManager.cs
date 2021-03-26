using GamingProject.Entitity;
using System;

namespace GamingProject
{
    internal class SaleManager : ISaleService
    {
        public void CampaignSale(Frisky frisky, Game game, Campaign campaign)
        {
            Console.WriteLine("'" + frisky.FirstName + " " + frisky.LastName + "'" + " purchased the game named " + "'" + game.Name + "' with " + campaign.Discount + " % discount");
        }
        public void Sale(Frisky frisky, Game game)
        {
            Console.WriteLine("'" + frisky.FirstName + " " + frisky.LastName + "'" + " purchased the game named " + "'" + game.Name + "'");
        }
    }
}
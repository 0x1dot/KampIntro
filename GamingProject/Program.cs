using System;
using GamingProject.Adapters;
using GamingProject.Entitity;

namespace GamingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Frisky frisky = new Frisky { Id = 1, FirstName = "Murat", LastName = "Dursun", Date = new DateTime(2000,08,21), IdentityID = 27571468336 };

            gamerManager.Add(frisky);
            gamerManager.Update(frisky);
            gamerManager.Delete(frisky);

            GameManager gameManager = new GameManager();
            Game game = new Game { Id = 1, Name = "7 Days To Die", UnitPrice = 70 };

            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 1, Name = "Discount on game", Discount = 30};

            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(frisky, game);

            saleManager.CampaignSale(frisky, game, campaign);
        }
    }
}

using GamingProject.Entitity;

namespace GamingProject
{
    interface ISaleService
    {
        void Sale(Frisky frisky, Game game);
        void CampaignSale(Frisky frisky, Game game, Campaign campaign);
    }
}
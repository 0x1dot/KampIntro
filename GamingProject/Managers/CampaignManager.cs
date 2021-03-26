using GamingProject.Entitity;
using System;

namespace GamingProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.Name + "'" + " campaign added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.Name + "'" + " campaign deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("'" + campaign.Name + "'" + " campaign updated.");
        }
    }
}
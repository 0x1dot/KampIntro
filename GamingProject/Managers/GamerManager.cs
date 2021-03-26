using System;

namespace GamingProject
{
    internal class GamerManager : BaseGamerManager
    {
        private IGamerCheckService gamerCheckService;
        public GamerManager(IGamerCheckService _gamerCheckService)
        {
            gamerCheckService = _gamerCheckService;
        }
        public override void Add(Frisky frisky)
        {
            if (gamerCheckService.CheckIfRealPerson(frisky)) base.Add(frisky);
            else throw new Exception("Not a valid person");
        }
        public override void Delete(Frisky frisky)
        {
            Console.WriteLine("'" + frisky.FirstName + " " + frisky.LastName + "'" + " Users Deleted.");
        }

        public override void Update(Frisky frisky)
        {
            Console.WriteLine("'" + frisky.FirstName + " " + frisky.LastName + "'" + " Users Updated.");
        }
    }
}

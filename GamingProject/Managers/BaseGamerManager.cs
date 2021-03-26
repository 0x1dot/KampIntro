using System;

namespace GamingProject
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Frisky frisky)
        {
            Console.WriteLine(" " + frisky.FirstName + " user added.");
        }

        public virtual void Delete(Frisky frisky)
        {
            Console.WriteLine(frisky.FirstName + " user deleted.");
        }

        public virtual void Update(Frisky frisky)
        {
            Console.WriteLine(frisky.FirstName + "user updated.");
        }
    }
}
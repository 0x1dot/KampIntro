using GamingProject.Entitity;

namespace GamingProject
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
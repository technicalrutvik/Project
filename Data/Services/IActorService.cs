using WebApplication1.Data.Base;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public interface IActorService : IEntityBaseRepositoty<Actor>
    { }
    //{
    //    Task<IEnumerable<Actor>> GetAllAsync();
    //    Task<Actor> GetByIdAsync(int id);
    //    Task AddAsync(Actor actor);

    //    Task<Actor> UpdateAsync(int id, Actor newActor);

    //    Task DeleteAsync(int id);
    //}
}

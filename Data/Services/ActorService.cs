using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDBContext _context;

        public ActorService(AppDBContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.aId == id);
            return result;

        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            newActor.aId = id;
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}

using WebApplication1.Data.Base;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService

    {
        public CinemaService(AppDBContext context): base(context)
        {

        }
       
    }
}

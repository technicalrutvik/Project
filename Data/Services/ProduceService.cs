using WebApplication1.Data.Base;
using WebApplication1.Models;
using WebApplication1.Data.Base;

namespace WebApplication1.Data.Services
{
    public class ProduceService : EntityBaseRepository<Producer>, IProduceService
    {
        public ProduceService(AppDBContext context):  base(context) 
        {
            
        }
    }
}

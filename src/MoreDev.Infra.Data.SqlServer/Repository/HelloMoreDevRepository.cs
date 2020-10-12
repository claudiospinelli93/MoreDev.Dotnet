using MoreDev.Domain.Entities;
using MoreDev.Domain.Interfaces.Repository;
using MoreDev.Infra.Data.SqlServer.Context;

namespace MoreDev.Infra.Data.SqlServer.Repository
{
    public class HelloMoreDevRepository : BaseRepository<HelloMoreDevEntity>, IHelloMoreDevRepository
    {
        public HelloMoreDevRepository(MoreDevContext context) : base(context)
        {

        }
    }
}

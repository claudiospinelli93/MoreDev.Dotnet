using Microsoft.EntityFrameworkCore;
using MoreDev.Domain.Entities;

namespace MoreDev.Infra.Data.SqlServer.Context
{
    public class MoreDevContext : DbContext
    {
        public DbSet<HelloMoreDevEntity> HelloMoreDev { get; set; }

        public MoreDevContext(DbContextOptions<MoreDevContext> options) : base(options)
        {
            
        }
    }
}

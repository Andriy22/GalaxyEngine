using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDBContext
    {
        public DbSet<Domain.Demo> Demos { get; set; }
        public DbSet<FrontPage> FrontPages { get; set; }
        public DbSet<FrontBaseComponent> FrontBaseComponents { get; set; }
        public DbSet<FrontComponentProp> FrontComponentProps { get; set; }
        public DbSet<FrontComponent> FrontComponents { get; set; }
        public DbSet<FrontPropValue> FrontPropValues { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();
    }
}

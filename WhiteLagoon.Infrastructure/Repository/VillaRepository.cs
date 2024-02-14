using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class VillaRepository(ApplicationDbContext db) : Repository<Villa>(db), IVillaRepository
    {
        private readonly ApplicationDbContext _db = db;

        public void Update(Villa entity)
        {
            _db.Villas.Update(entity);
        }
    }
}

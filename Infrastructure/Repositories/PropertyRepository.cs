using Real_estate.Domain.Entities;
using Real_estate.Application.Persistence;


namespace Infrastructure.Repositories
{
    public class PropertyRepository : BaseRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(RealEstateContext context) : base(context)
        {
        }
    }
}

using Real_estate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PropretyRepository : BaseRepository<Proprety>
    {
        public PropretyRepository(RealEstateContext context) : base(context)
        {

        }
    }
}

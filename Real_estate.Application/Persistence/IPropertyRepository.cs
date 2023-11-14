using Real_estate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate.Application.Persistence
{
    public interface IPropertyRepository : IAsyncRepository<Property>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate.Application.Features.Properties.Commands.CreateProperty
{
    public class CreatePropertyDto
    {
        public Guid PropertyId { get; set; }   
        public string? PropertyTitle { get; set; }
    }
}

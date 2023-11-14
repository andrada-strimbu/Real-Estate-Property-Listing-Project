using MediatR;
 

namespace Real_estate.Application.Features.Properties.Commands.CreateProperty
{
    public class CreatePropertyCommand : IRequest<CreatePropertyCommandResponse>
    {
        public string PropertyTitle { get; set; } = default!;

    }
}

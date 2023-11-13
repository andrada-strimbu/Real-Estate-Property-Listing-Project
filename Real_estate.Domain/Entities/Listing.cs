using Real_estate.Domain.Common;
using static Real_estate.Domain.Enums.Enums;

namespace Real_estate.Domain.Entities
{
    public class Listing : AuditableEntity
    {
        private Listing(string title, User user, Proprety proprety, string description)
        {
            ListingId = Guid.NewGuid();
            Title = title;
            User = user;
            Proprety = proprety;
            Description = description;
        }

        public Guid ListingId { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public User User { get; private set; }
        public Proprety Proprety { get; private set; }
        public string Description { get; private set; }


        public static Result<Listing> Create(string title, User user, Proprety proprety, string description)
        {
            userRole = user.UserRole.get();
            if (string.IsNullOrWhiteSpace(title))
            {
                return Result<Listing>.Failure("Title is required.");
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                return Result<Listing>.Failure("Description is required.");
            }
            if (userRole != Role.Owner)
            {
                return Result<Listing>.Failure("Listing creator must be an Owner")
            }
            return Result<Listing>.Succes(new Listing(title,user,proprety,description));
        }


        

    }
}

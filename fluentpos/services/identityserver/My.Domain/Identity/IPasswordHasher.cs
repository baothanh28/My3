using My.Domain.Entities;

namespace My.Domain.Identity
{
    public interface IPasswordHasher
    {
        bool VerifyHashedPassword(User user, string hashedPassword, string providedPassword);
    }
}

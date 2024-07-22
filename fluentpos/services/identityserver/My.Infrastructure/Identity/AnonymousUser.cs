using My.Domain.Identity;
using System;

namespace My.Infrastructure.Identity
{
    public class AnonymousUser : ICurrentUser
    {
        public bool IsAuthenticated => false;

        public Guid UserId => Guid.Empty;
    }
}

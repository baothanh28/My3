using My.Domain.Entities;
using System;

namespace My.IdentityServer.Models.UserModels
{
    public class RoleModel
    {
        public Guid RoleId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Role Role { get; set; }
    }
}

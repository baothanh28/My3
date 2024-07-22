using My.Domain.Entities;
using System;
using System.Collections.Generic;

namespace My.IdentityServer.Models.RoleModels
{
    public class UsersModel
    {
        public Role Role { get; set; }

        public List<User> Users { get; set; }
    }
}

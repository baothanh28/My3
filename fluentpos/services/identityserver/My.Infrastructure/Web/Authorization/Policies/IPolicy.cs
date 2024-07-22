﻿using Microsoft.AspNetCore.Authorization;

namespace My.Infrastructure.Web.Authorization.Policies
{
    public interface IPolicy
    {
        void Configure(AuthorizationPolicyBuilder policy);
    }
}

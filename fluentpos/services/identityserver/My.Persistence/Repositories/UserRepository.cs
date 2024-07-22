﻿using My.CrossCuttingConcerns.DateTimes;
using My.Domain.Entities;
using My.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace My.Persistence.Repositories
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(AdsDbContext dbContext, IDateTimeProvider dateTimeProvider)
            : base(dbContext, dateTimeProvider)
        {
        }

        public IQueryable<User> Get(UserQueryOptions queryOptions)
        {
            var query = GetQueryableSet();

            if (queryOptions.IncludePasswordHistories)
            {
                query = query.Include(x => x.PasswordHistories);
            }

            if (queryOptions.IncludeTokens)
            {
                query = query.Include(x => x.Tokens);
            }

            if (queryOptions.IncludeClaims)
            {
                query = query.Include(x => x.Claims);
            }

            if (queryOptions.IncludeUserRoles)
            {
                query = query.Include(x => x.UserRoles);
            }

            if (queryOptions.IncludeRoles)
            {
                query = query.Include("UserRoles.Role");
            }

            if (queryOptions.AsNoTracking)
            {
                query = query = query.AsNoTracking();
            }

            return query;
        }
    }
}

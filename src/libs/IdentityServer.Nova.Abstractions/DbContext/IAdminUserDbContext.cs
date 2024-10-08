﻿using IdentityServer.Nova.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityServer.Nova.Abstractions.DbContext;

public interface IAdminUserDbContext : IUserDbContext
{
    Task<IEnumerable<ApplicationUser>> GetUsersAsync(int limit, int skip, CancellationToken cancellationToken);

    Task<IEnumerable<ApplicationUser>> FindUsers(string term, CancellationToken cancellationToken);
}

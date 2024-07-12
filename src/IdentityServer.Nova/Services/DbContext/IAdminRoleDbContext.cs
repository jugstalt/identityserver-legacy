﻿using IdentityServer.Nova.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityServer.Nova.Services.DbContext;

public interface IAdminRoleDbContext
{
    Task<IEnumerable<ApplicationRole>> GetRolesAsync(int limit, int skip, CancellationToken cancellationToken);

    Task<IEnumerable<ApplicationRole>> FindRoles(string term, CancellationToken cancellationToken);
}
﻿using System.Threading;
using System.Threading.Tasks;

namespace IdentityServer.Legacy.Services.DbContext
{
    public interface IUserDbContextPreActions : IUserDbContext
    {
        Task<ApplicationUser> PreCreateAsync(ApplicationUser user, CancellationToken cancellationToken);
    }
}

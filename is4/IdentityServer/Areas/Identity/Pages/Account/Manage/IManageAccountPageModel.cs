﻿using IdentityServer.Legacy.UserInteraction;
using System.Threading.Tasks;

namespace IdentityServer.Areas.Identity.Pages.Account.Manage
{
    public interface IManageAccountPageModel
    {
        Task<ManageAccountEditor> EditorInfos();
    }
}

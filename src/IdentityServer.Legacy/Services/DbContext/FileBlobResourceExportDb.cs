﻿using IdentityServer.Legacy.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Legacy.Services.DbContext
{
    public class FileBlobResourceExportDb : FileBlobResourceDb, IExportResourceDbContext
    {
        public FileBlobResourceExportDb(IOptions<ExportResourceDbContextConfiguration> options)
            : base(options)
        {

        }

        #region IResourceDbContextExport

        public Task FlushDb()
        {
            foreach (var fi in new DirectoryInfo(_rootPath).GetFiles("*.api").ToArray())
            {
                fi.Delete();
            }

            foreach (var fi in new DirectoryInfo(_rootPath).GetFiles("*.identity").ToArray())
            {
                fi.Delete();
            }

            return Task.CompletedTask;
        }

        #endregion
    }
}

using CorsDbPersistedSandbox.Models;
using System.Collections.Generic;
using System.Linq;

namespace CorsDbPersistedSandbox.Services
{
    public sealed class UriService
    {
        readonly WhitelistContext _ctx;

        public UriService(WhitelistContext ctx)
        {
            _ctx = ctx;
        }

        public List<CorsUri> GetWhitelistedUris()
        {
            return _ctx.CorsUris.ToList();
        }

        public void AddWhitelistedUri(CorsUri newUri)
        {
            _ctx.CorsUris.Add(newUri);
            _ctx.SaveChanges();
        }
    }
}

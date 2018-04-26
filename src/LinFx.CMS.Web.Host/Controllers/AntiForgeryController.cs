using Microsoft.AspNetCore.Antiforgery;
using LinFx.CMS.Controllers;

namespace LinFx.CMS.Web.Host.Controllers
{
    public class AntiForgeryController : CMSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

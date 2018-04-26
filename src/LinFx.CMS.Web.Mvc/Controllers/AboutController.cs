using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LinFx.CMS.Controllers;

namespace LinFx.CMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace LinFx.CMS.Web.Views
{
    public abstract class CMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CMSRazorPage()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}

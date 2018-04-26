using Abp.AspNetCore.Mvc.ViewComponents;

namespace LinFx.CMS.Web.Views
{
    public abstract class CMSViewComponent : AbpViewComponent
    {
        protected CMSViewComponent()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}

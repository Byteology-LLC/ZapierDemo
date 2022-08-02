using ZapierDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ZapierDemo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ZapierDemoPageModel : AbpPageModel
{
    protected ZapierDemoPageModel()
    {
        LocalizationResourceType = typeof(ZapierDemoResource);
    }
}

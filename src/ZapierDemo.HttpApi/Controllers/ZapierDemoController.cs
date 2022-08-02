using ZapierDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ZapierDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ZapierDemoController : AbpControllerBase
{
    protected ZapierDemoController()
    {
        LocalizationResource = typeof(ZapierDemoResource);
    }
}

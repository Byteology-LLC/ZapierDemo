using System;
using System.Collections.Generic;
using System.Text;
using ZapierDemo.Localization;
using Volo.Abp.Application.Services;

namespace ZapierDemo;

/* Inherit your application services from this class.
 */
public abstract class ZapierDemoAppService : ApplicationService
{
    protected ZapierDemoAppService()
    {
        LocalizationResource = typeof(ZapierDemoResource);
    }
}

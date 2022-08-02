using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ZapierDemo.Web;

[Dependency(ReplaceServices = true)]
public class ZapierDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ZapierDemo";
}

using Volo.Abp.Modularity;

namespace ZapierDemo;

[DependsOn(
    typeof(ZapierDemoApplicationModule),
    typeof(ZapierDemoDomainTestModule)
    )]
public class ZapierDemoApplicationTestModule : AbpModule
{

}

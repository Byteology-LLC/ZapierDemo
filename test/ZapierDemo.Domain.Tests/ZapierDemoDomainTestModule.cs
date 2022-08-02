using ZapierDemo.MongoDB;
using Volo.Abp.Modularity;

namespace ZapierDemo;

[DependsOn(
    typeof(ZapierDemoMongoDbTestModule)
    )]
public class ZapierDemoDomainTestModule : AbpModule
{

}

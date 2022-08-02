using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace ZapierDemo.MongoDB;

[DependsOn(
    typeof(ZapierDemoTestBaseModule),
    typeof(ZapierDemoMongoDbModule)
    )]
public class ZapierDemoMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = ZapierDemoMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}

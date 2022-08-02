using ZapierDemo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ZapierDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ZapierDemoMongoDbModule),
    typeof(ZapierDemoApplicationContractsModule)
    )]
public class ZapierDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ZapierDemo.Data;

/* This is used if database provider does't define
 * IZapierDemoDbSchemaMigrator implementation.
 */
public class NullZapierDemoDbSchemaMigrator : IZapierDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

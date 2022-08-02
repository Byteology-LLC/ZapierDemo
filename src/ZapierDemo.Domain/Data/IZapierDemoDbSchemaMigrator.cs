using System.Threading.Tasks;

namespace ZapierDemo.Data;

public interface IZapierDemoDbSchemaMigrator
{
    Task MigrateAsync();
}

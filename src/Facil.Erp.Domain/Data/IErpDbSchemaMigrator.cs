using System.Threading.Tasks;

namespace Facil.Erp.Data;

public interface IErpDbSchemaMigrator
{
    Task MigrateAsync();
}

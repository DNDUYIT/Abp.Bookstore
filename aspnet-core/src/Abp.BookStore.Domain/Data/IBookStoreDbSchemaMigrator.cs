using System.Threading.Tasks;

namespace Abp.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}

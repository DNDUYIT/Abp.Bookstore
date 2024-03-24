using Xunit;

namespace Abp.BookStore.EntityFrameworkCore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreEntityFrameworkCoreCollection : ICollectionFixture<BookStoreEntityFrameworkCoreFixture>
{

}

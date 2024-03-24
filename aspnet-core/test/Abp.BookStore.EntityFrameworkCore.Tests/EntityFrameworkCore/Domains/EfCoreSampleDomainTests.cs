using Abp.BookStore.Samples;
using Xunit;

namespace Abp.BookStore.EntityFrameworkCore.Domains;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreEntityFrameworkCoreTestModule>
{

}

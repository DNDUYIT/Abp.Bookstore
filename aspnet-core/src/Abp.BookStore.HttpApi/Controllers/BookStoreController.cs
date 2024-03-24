using Abp.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Abp.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Abp.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}

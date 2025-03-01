﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.BookStore;

[Dependency(ReplaceServices = true)]
public class BookStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStore";
}

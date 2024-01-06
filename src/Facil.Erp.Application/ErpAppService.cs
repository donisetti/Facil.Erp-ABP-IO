using System;
using System.Collections.Generic;
using System.Text;
using Facil.Erp.Localization;
using Volo.Abp.Application.Services;

namespace Facil.Erp;

/* Inherit your application services from this class.
 */
public abstract class ErpAppService : ApplicationService
{
    protected ErpAppService()
    {
        LocalizationResource = typeof(ErpResource);
    }
}

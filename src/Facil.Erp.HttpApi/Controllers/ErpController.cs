using Facil.Erp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Facil.Erp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ErpController : AbpControllerBase
{
    protected ErpController()
    {
        LocalizationResource = typeof(ErpResource);
    }
}

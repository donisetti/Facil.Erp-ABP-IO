using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Facil.Erp.Web;

[Dependency(ReplaceServices = true)]
public class ErpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Erp";
}

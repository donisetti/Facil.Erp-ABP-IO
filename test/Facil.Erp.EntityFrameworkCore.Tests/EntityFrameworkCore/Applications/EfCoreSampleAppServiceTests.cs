using Facil.Erp.Samples;
using Xunit;

namespace Facil.Erp.EntityFrameworkCore.Applications;

[Collection(ErpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ErpEntityFrameworkCoreTestModule>
{

}

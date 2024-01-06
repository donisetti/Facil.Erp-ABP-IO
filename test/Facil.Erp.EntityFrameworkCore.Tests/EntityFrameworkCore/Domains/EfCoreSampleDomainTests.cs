using Facil.Erp.Samples;
using Xunit;

namespace Facil.Erp.EntityFrameworkCore.Domains;

[Collection(ErpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ErpEntityFrameworkCoreTestModule>
{

}

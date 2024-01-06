using Xunit;

namespace Facil.Erp.EntityFrameworkCore;

[CollectionDefinition(ErpTestConsts.CollectionDefinitionName)]
public class ErpEntityFrameworkCoreCollection : ICollectionFixture<ErpEntityFrameworkCoreFixture>
{

}

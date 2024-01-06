using Microsoft.AspNetCore.Builder;
using Facil.Erp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ErpWebTestModule>();

public partial class Program
{
}

﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Facil.Erp.Pages;

public class Index_Tests : ErpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

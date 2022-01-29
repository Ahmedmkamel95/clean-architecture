using NUnit.Framework;

namespace clean_architecture.Application.IntegrationTests;

using static Testing;

public class TestBase
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}

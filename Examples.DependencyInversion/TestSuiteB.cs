using Examples.DependencyInversion.Support;

namespace Examples.DependencyInversion;

public class TestSuiteB
{
    [Fact]
    public void Should_See_Bar()
    {
        // create out stub environment variable/s
        var environmentVariables = new InMemoryEnvironmentVariableProvider(new()
        {
            { "ENVIRONMENT_VARIABLE", "Bar" },
        });

        // create out system under test, passing out stub via constructor dependency injection
        var sut = new SystemUnderTest(environmentVariables);

        // assert our system under test has visibility of our set environment variable
        Assert.Equal("Bar", sut.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));
    }
}

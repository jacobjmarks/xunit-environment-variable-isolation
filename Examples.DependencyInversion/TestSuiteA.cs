using Examples.DependencyInversion.Support;

namespace Examples.DependencyInversion;

public class TestSuiteA
{
    [Fact]
    public void Should_See_Foo()
    {
        // create out stub environment variable/s
        var environmentVariables = new InMemoryEnvironmentVariableProvider(new()
        {
            { "ENVIRONMENT_VARIABLE", "Foo" },
        });

        // create out system under test, passing out stub via constructor dependency injection
        var sut = new SystemUnderTest(environmentVariables);

        // assert our system under test has visibility of our set environment variable
        Assert.Equal("Foo", sut.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));
    }
}

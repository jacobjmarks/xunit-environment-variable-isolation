using Examples.SerialExecution.Support;

namespace Examples.SerialExecution;

[Collection(nameof(Environment))]
public class TestSuiteB
{
    [Fact]
    public void Should_See_Bar()
    {
        // ensure we are starting the test with a clean slate
        Assert.Null(Environment.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));

        // create out temporary environment variable/s
        using var environmentVariable = new TemporaryEnvironmentVariable("ENVIRONMENT_VARIABLE", "Bar");

        // create our system under test
        var sut = new SystemUnderTest();

        // assert our system under test has visibility of our set environment variable
        Assert.Equal("Bar", sut.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));
    }
}

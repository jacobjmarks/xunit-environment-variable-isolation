using Examples.SerialExecution.Support;

namespace Examples.SerialExecution;

[Collection(nameof(Environment))]
public class TestSuiteA
{
    [Fact]
    public void Should_See_Foo()
    {
        // ensure we are starting the test with a clean slate
        Assert.Null(Environment.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));

        // create out temporary environment variable/s
        using var environmentVariable = new TemporaryEnvironmentVariable("ENVIRONMENT_VARIABLE", "Foo");

        // create our system under test
        var sut = new SystemUnderTest();

        // assert our system under test has visibility of our set environment variable
        Assert.Equal("Foo", sut.GetEnvironmentVariable("ENVIRONMENT_VARIABLE"));
    }
}

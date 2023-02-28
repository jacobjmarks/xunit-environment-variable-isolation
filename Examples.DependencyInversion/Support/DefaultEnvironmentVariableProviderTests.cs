namespace Examples.DependencyInversion.Support;

/// <summary>
/// A suite of tests for the <see cref="DefaultEnvironmentVariableProvider" />
/// </summary>
[Collection(nameof(Environment))]
public class DefaultEnvironmentVariableProviderTests
{
    [Fact]
    public void Should_Get_Environment_Variable()
    {
        //- arrange
        var variable = "ENVIRONMENT_VARIABLE";
        var expectedValue = Guid.NewGuid().ToString();
        Environment.SetEnvironmentVariable(variable, expectedValue);

        var provider = new DefaultEnvironmentVariableProvider();

        //- act
        var actualValue = provider.Get(variable);

        //- assert
        Assert.Equal(expectedValue, actualValue);
    }
}

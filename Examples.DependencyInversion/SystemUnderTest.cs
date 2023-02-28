using Examples.DependencyInversion.Support;

namespace Examples.DependencyInversion;

/// <summary>
/// A System Under Test which utilises one or more environment variables.
/// 
/// Environment variables are not accessed directly, but are done so via an
/// abstraction in the form of an interface.
/// 
/// This is an example of dependency inversion and injection.
/// </summary>
public class SystemUnderTest
{
    private readonly IEnvironmentVariableProvider _environmentVariables;

    public SystemUnderTest(IEnvironmentVariableProvider environmentVariables)
    {
        _environmentVariables = environmentVariables;
    }

    public string? GetEnvironmentVariable(string variable)
    {
        return _environmentVariables.Get(variable);
    }
}

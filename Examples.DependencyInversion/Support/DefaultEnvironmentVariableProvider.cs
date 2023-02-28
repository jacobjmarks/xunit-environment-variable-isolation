namespace Examples.DependencyInversion.Support;

/// <summary>
/// A default implementation of the <see cref="IEnvironmentVariableProvider" />
/// which provides environment variables via <see cref="System.Environment" />
/// </summary>
public class DefaultEnvironmentVariableProvider : IEnvironmentVariableProvider
{
    public string? Get(string variable)
    {
        return Environment.GetEnvironmentVariable(variable);
    }
}

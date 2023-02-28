namespace Examples.DependencyInversion.Support;

/// <summary>
/// A stub implementation of the <see cref="IEnvironmentVariableProvider" />
/// in which environment variables are provided via an in-memory collection.
/// 
/// To be used for automated testing purposes.
/// </summary>
public class InMemoryEnvironmentVariableProvider : IEnvironmentVariableProvider
{
    private readonly Dictionary<string, string?> _variables;

    public InMemoryEnvironmentVariableProvider(Dictionary<string, string?> variables)
    {
        _variables = new(variables);
    }

    public string? Get(string variable)
    {
        return _variables.GetValueOrDefault(variable);
    }
}

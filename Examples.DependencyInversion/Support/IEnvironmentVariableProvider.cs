namespace Examples.DependencyInversion.Support;

/// <summary>
/// An interface to be used to abstract the access to environment variables
/// </summary>
public interface IEnvironmentVariableProvider
{
    string? Get(string variable);
}

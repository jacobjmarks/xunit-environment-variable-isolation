namespace Examples.SerialExecution.Support;

/// <summary>
/// An abstraction which represents a temporary environment variable
/// which will be reset to its initial value upon disposal.
/// </summary>
public class TemporaryEnvironmentVariable : IDisposable
{
    private readonly string _name;
    private readonly string? _previousValue;

    public TemporaryEnvironmentVariable(string name, string? value)
    {
        _name = name;
        _previousValue = Environment.GetEnvironmentVariable(name);

        Environment.SetEnvironmentVariable(name, value);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Environment.SetEnvironmentVariable(_name, _previousValue);
    }
}

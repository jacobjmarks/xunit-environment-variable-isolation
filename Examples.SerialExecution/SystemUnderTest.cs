namespace Examples.SerialExecution;

/// <summary>
/// A System Under Test which utilises one or more environment variables.
/// 
/// The system accesses environment variables directly via <see cref="System.Environment" />
/// </summary>
public class SystemUnderTest
{
    public string? GetEnvironmentVariable(string variable)
    {
        return Environment.GetEnvironmentVariable(variable);
    }
}

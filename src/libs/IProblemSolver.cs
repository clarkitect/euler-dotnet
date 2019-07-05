namespace euler_dotnet.libs
{
    /// <summary>
    /// Generic Solution Method
    /// </summary>
    /// <typeparam name="TResultType"></typeparam>
    public interface IProblemSolver<out TResultType>
    {
        TResultType Solve(params object[] args);
    }
}
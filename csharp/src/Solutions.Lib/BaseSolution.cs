namespace Solutions.Lib;

public abstract class BaseSolution
{
    public object Execute(params object[] parameters)
    {
        return Solve(parameters);
    }

    protected abstract object Solve(object[] parameters);
}

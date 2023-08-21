using Solutions.Lib;

namespace Solutions.Tests;

public abstract class BaseSolutionTests<TSolution> : IClassFixture<BaseSolutionTests<TSolution>.BaseSolutionFixture>
    where TSolution : BaseSolution
{
    public readonly BaseSolutionFixture Fixture;

    public BaseSolutionTests(BaseSolutionFixture fixture)
    {
        Fixture = fixture;
    }

    public class BaseSolutionFixture
    {
        public TSolution Solution { get; }

        public BaseSolutionFixture()
        {
            Solution = Activator.CreateInstance<TSolution>();
        }
    }
}

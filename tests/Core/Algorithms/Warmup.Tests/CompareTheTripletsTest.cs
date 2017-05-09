using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class CompareTheTripletsTest : BaseTest
    {
        public CompareTheTripletsTest(ITestOutputHelper output) : base(output)
        {
        }

        protected override void RunLogic()
        {
            CompareTheTriplets.Main();
        }
    }
}

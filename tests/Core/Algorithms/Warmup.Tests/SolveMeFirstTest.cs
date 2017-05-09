using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class SolveMeFirstTest : BaseTest
    {
        public SolveMeFirstTest(ITestOutputHelper output) : base(output)
        {
        }

        protected override void RunLogic()
        {
            SolveMeFirst.Main();
        }
    }
}

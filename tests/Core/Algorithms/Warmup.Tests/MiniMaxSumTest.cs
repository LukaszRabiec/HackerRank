using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class MiniMaxSumTest : BaseTest
    {
        public MiniMaxSumTest(ITestOutputHelper output) : base(output, MiniMaxSum.Main)
        {
        }
    }
}

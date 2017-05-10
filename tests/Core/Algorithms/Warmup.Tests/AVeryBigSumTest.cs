using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class AVeryBigSumTest : BaseTest
    {
        public AVeryBigSumTest(ITestOutputHelper output) : base(output, AVeryBigSum.Main)
        {
        }
    }
}

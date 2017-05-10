using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class SimpleArraySumTest : BaseTest
    {
        public SimpleArraySumTest(ITestOutputHelper output) : base(output, SimpleArraySum.Main)
        {
        }
    }
}

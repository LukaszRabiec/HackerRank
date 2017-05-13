using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class BirthdayCakeCandlesTest : BaseTest
    {
        public BirthdayCakeCandlesTest(ITestOutputHelper output) : base(output, BirthdayCakeCandles.Main)
        {
        }
    }
}

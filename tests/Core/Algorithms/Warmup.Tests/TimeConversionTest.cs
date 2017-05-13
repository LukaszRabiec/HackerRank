using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class TimeConversionTest : BaseTest
    {
        public TimeConversionTest(ITestOutputHelper output) : base(output, TimeConversion.Main)
        {
        }
    }
}

using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class DiagonalDifferenceTest : BaseTest
    {
        public DiagonalDifferenceTest(ITestOutputHelper output) : base(output, DiagonalDifference.Main)
        {
        }
    }
}

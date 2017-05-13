using TestsCore;
using Xunit;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class WarmupTests : BaseTest
    {
        public WarmupTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void SolveMeFirstTest()
        {
            Run(SolveMeFirst.Main);
        }

        [Fact]
        public void SimpleArraySumTest()
        {
            Run(SimpleArraySum.Main);
        }

        [Fact]
        public void CompareTheTripletsTest()
        {
            Run(CompareTheTriplets.Main);
        }

        [Fact]
        public void AVeryBigSumTest()
        {
            Run(AVeryBigSum.Main);
        }

        [Fact]
        public void DiagonalDifferenceTest()
        {
            Run(DiagonalDifference.Main);
        }

        [Fact]
        public void PlusMinusTest()
        {
            Run(PlusMinus.Main);
        }

        [Fact]
        public void StaircaseTest()
        {
            Run(Staircase.Main);
        }

        [Fact]
        public void MiniMaxSumTest()
        {
            Run(MiniMaxSum.Main);
        }

        [Fact]
        public void BirthdayCakeCandlesTest()
        {
            Run(BirthdayCakeCandles.Main);
        }

        [Fact]
        public void TimeConversionTest()
        {
            Run(TimeConversion.Main);
        }
    }
}

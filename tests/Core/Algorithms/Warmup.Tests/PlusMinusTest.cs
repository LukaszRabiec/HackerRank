using TestsCore;
using Xunit.Abstractions;

namespace Warmup.Tests
{
    public class PlusMinusTest : BaseTest
    {
        public PlusMinusTest(ITestOutputHelper output) : base(output, PlusMinus.Main)
        {
        }
    }
}

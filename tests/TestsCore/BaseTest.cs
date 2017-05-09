using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace TestsCore
{
    public abstract class BaseTest
    {
        protected abstract void RunLogic();

        private static ITestOutputHelper _output;

        protected BaseTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Run()
        {
            int i = 0;
            var testCases = GetTestCases();

            foreach (var testCase in testCases)
            {
                var writer = new StringWriter();
                Console.SetOut(writer);

                var reader = new StringReader(testCase.Input);
                Console.SetIn(reader);

                RunLogic();

                var result = writer.ToString().TrimEnd('\r', '\n');
                Assert.Equal(testCase.Expected, result);

                _output.WriteLine($"Test case #{i++}:");
                _output.WriteLine($"Input:\n{testCase.Input}");
                _output.WriteLine($"Expected:\n{testCase.Expected}");
                _output.WriteLine($"Actual:\n{result}");
                _output.WriteLine("");
            }
        }

        private IEnumerable<TestData> GetTestCases()
        {
            var childClassName = GetType().Name;
            var testsFileName = childClassName.Replace("Test", ".json");

            return FromJsonFile(testsFileName);
        }

        private IEnumerable<TestData> FromJsonFile(string fileName)
        {
            using (var streamReader = new StreamReader($"TestsCases/{fileName}"))
            {
                return JsonConvert.DeserializeObject<IEnumerable<TestData>>(streamReader.ReadToEnd());
            }
        }
    }
}

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
        protected delegate void LogicMethod();

        private static ITestOutputHelper _output;

        protected BaseTest(ITestOutputHelper output)
        {
            _output = output;
        }

        protected void Run(LogicMethod logicMethod)
        {
            int i = 0;
            var methodClassName = logicMethod.Method.ReflectedType?.Name;
            var testCases = GetTestCases(methodClassName);

            foreach (var testCase in testCases)
            {
                var writer = new StringWriter();
                Console.SetOut(writer);

                var reader = new StringReader(testCase.Input);
                Console.SetIn(reader);

                logicMethod();

                var result = writer.ToString().TrimEnd('\r', '\n');
                Assert.Equal(testCase.Expected, result);

                _output.WriteLine($"Test case #{i++}:");
                _output.WriteLine($"Input:\n{testCase.Input}");
                _output.WriteLine($"Expected:\n{testCase.Expected}");
                _output.WriteLine($"Actual:\n{result}");
                _output.WriteLine("");
            }
        }

        private IEnumerable<TestData> GetTestCases(string methodClassName)
        {
            var testsFileName = methodClassName + ".json";

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

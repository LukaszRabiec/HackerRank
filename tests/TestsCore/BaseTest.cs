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

        private readonly ITestOutputHelper _output;
        private readonly Dictionary<string, IEnumerable<TestData>> _casesDictionary;

        protected BaseTest(ITestOutputHelper output)
        {
            _output = output;
            _casesDictionary = GetTestCases();

        }

        protected void Run(LogicMethod logicMethod)
        {
            int i = 0;
            var methodClassName = logicMethod.Method.ReflectedType?.Name ?? throw new Exception("Reflected Name of Method cannot be a null.");

            foreach (var testCase in _casesDictionary[methodClassName])
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

        private Dictionary<string, IEnumerable<TestData>> GetTestCases()
        {
            var childClassName = GetType().Name;
            var testsFileName = childClassName.Replace("Tests", "Cases.json");

            return FromJsonFile(testsFileName);
        }

        private Dictionary<string, IEnumerable<TestData>> FromJsonFile(string fileName)
        {
            using (var streamReader = new StreamReader($"TestsCases/{fileName}"))
            {
                return JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<TestData>>>(streamReader.ReadToEnd());
            }
        }
    }
}

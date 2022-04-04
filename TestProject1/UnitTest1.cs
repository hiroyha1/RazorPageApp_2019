using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string json = "{\"name\": \"Hiroyuki\"}";
            var obj = JObject.Parse(json);
            Console.WriteLine("Hello World");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Hello World");
        }
    }
}

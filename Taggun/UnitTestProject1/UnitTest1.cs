using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodsimple()
        {
            var sut = new Taggun.Taggun();
            var file = @"C:\Users\Jon\Documents\Projects\Github\IMG_4124B9BB22BE-1.jpeg";
            var data = sut.RunService(file, System.IO.File.ReadAllText(@"C:\Users\Jon\Documents\Projects\Github\API-Taggun.txt.txt"), @"https://api.taggun.io/api/receipt/v1/simple/file");
            var result = sut.ConvertToSimpleJson(data);
        }
        [TestMethod]
        public void TestMethodverbose()
        {
            var sut = new Taggun.Taggun();
            var file = @"C:\Users\Jon\Documents\Projects\Github\IMG_4124B9BB22BE-1.jpeg";
            var data = sut.RunService(file, System.IO.File.ReadAllText(@"C:\Users\Jon\Documents\Projects\Github\API-Taggun.txt.txt"), @"https://api.taggun.io/api/receipt/v1/verbose/file");
            var result = sut.ConvertToVerboseJson(data);
        }
    }
}

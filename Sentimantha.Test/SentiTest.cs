using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sentimantha.TextAnalyzer;

namespace Sentimantha.Test {
    [TestClass]
    public class SentiTest {
        [TestMethod]
        public void ExpandTest() {
            Assert.AreEqual("isn't", Maxxer.Expand("is not"));
        }
        [TestMethod]
        public void StopwordTest() {
            TextAnalyzer.TextAnalyzer TA = new Sentimantha.TextAnalyzer.TextAnalyzer(@"C:\Users\Opsi Jay\Documents\Visual Studio 2017\Projects\Sentimantha\Sentimantha\stopwords.txt");
            Assert.AreEqual("isn't", Maxxer.Expand("is not"));
        }
    }
}

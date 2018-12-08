using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace WPFExample.Tests
{
    [TestClass]
    public class ImporterTest
    {
        [TestMethod]
        public void ReadTest()
        {
            var importer = new Importer();

            var questions = importer.ReadQuestions();

            Assert.IsTrue(questions.Count > 0);
        }
    }
}

// <copyright file="CowTest.cs">Copyright ©  2017</copyright>
using System;
using Cow;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cow.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Cow</summary>
    [PexClass(typeof(global::Cow.Cow))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CowTest
    {
        /// <summary>Тестовая заглушка для CowCounter(Int32)</summary>
        [PexMethod]
        public string CowCounterTest([PexAssumeUnderTest]global::Cow.Cow target, int count)
        {
            string result = target.CowCounter(count);
            return result;
            // TODO: добавление проверочных утверждений в метод CowTest.CowCounterTest(Cow, Int32)
        }
    }
}

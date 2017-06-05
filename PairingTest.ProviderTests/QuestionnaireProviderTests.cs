using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.Providers.Providers;

namespace PairingTest.ProviderTests
{
    [TestClass]
    public class QuestionnaireProviderTests
    {
        [TestMethod]
        public void GetQuestionnaireTest()
        {
            var t = new QuestionnaireProvider().GetQuestionnaire();

            var result = t;

            Assert.IsTrue(result!= null);
        }
    }
}

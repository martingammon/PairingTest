using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairingTest.QuestionServiceApi.Controllers;

namespace PairingTest.QuestionServiceApi.Tests
{
    [TestClass]
    public class QuestionsControllerTests
    {
        private readonly QuestionsController _questionsController;
        public QuestionsControllerTests()
        {
            _questionsController = new QuestionsController();
        }

        [TestMethod]
        public void GetQuestionnaireTest()
        {
            var t = _questionsController.GetQuestionnaire();
           

            Assert.IsFalse(t==null);
        }

    }
}

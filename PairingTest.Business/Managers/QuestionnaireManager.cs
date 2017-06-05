using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PairingTest.Business.Contracts;
using PairingTest.Models;

namespace PairingTest.Business.Managers
{
    public class QuestionnaireManager : IQuestionnaireManager
    {
        public Questionnaire GetQuestionnaire()
        {
            var q = new Questionnaire
            {
                Title = "Geography Questions",
                QandAList = new List<QuestionAndAnswer>
                {
                    new QuestionAndAnswer {Question = "What is the capital of Cuba?"},
                    new QuestionAndAnswer {Question = "What is the capital of France?"},
                    new QuestionAndAnswer {Question = "What is the capital of Poland?"},
                    new QuestionAndAnswer {Question = "What is the capital of Germany?"}
                }
            };
            return q;
        }
        
    }
}

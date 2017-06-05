using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PairingTest.Business.Contracts;
using PairingTest.Models;
using PairingTest.Providers.Interfaces;

namespace PairingTest.Providers.Providers
{
    public class QuestionnaireProvider: IQuestionnaireProvider
    {
        private IQuestionnaireManager QuestionnaireManager => AutofacConfig.OdiContainer.Resolve<IQuestionnaireManager>();

        public Questionnaire GetQuestionnaire()
        {
            return QuestionnaireManager.GetQuestionnaire();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PairingTest.Models;

namespace PairingTest.Business.Contracts
{
    public interface IQuestionnaireManager
    {
        Questionnaire GetQuestionnaire();
    }
}

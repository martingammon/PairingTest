using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PairingTest.Models;

namespace PairingTest.Providers.Interfaces
{
    public interface IQuestionnaireProvider
    {
        Questionnaire GetQuestionnaire();
    }
}

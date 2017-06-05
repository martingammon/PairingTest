using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using PairingTest.Models;
using PairingTest.Providers.Providers;

namespace PairingTest.QuestionServiceApi.Controllers
{
    [Route("Questions")]
    public class QuestionsController : ApiController
    {
        [HttpGet]
        public Questionnaire GetQuestionnaire()
        {
            try
            {
                var result = new QuestionnaireProvider().GetQuestionnaire();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

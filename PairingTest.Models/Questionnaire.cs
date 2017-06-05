using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairingTest.Models
{
    public class Questionnaire
    {
        
        public string Title { get; set; }
        public IList<QuestionAndAnswer> QandAList { get; set; }
    }
}

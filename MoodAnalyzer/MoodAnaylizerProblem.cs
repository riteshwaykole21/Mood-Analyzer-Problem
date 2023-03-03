using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnaylizerProblem
    {
        string message;
        public MoodAnaylizerProblem(string message)
        {
            this.message = message;
        }
        public string AnaylseMood()
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
                return "Happy";
        }
    }
}

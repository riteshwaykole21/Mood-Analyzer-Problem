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
        public string AnaylseMood(string message)
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

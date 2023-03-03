using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
   public  class MoodAnalyzerProblem
    {
        public string Mood(string m)
        {
            if (m == "Happy")
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}

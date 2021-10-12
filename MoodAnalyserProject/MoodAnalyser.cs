using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        public string Analyzer(string mood)
        {
            if (mood.Contains("sad"))
                return "sad";
            else
                return"happy";
        }
    }
}

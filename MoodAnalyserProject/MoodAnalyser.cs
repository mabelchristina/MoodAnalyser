using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string Analyzer()
        {
            if (this.message.Contains("sad"))
                return "sad";
            else
                return "happy";
        }
    }
}

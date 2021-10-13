using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            Console.WriteLine("this is default constructor");
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string Analyzer()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                    return "happy";
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}

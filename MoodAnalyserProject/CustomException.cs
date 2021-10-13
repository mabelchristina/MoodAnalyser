using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProject
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_CLASS,NO_SUCH_METHOD,NO_SUCH_FIELD, OBJECT_CREATION_ISSUE,NO_SUCH_EXCEPTION
        }
        private readonly ExceptionType type;
        public CustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}

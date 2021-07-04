using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCenceAnalyse
{
    class CensusAnalyserException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,INVALID_FILE_TYPE,INCORRECT_DELIMITER,INCORRECT_HEADER,NO_SUCH_COUNTER
        }
        public ExceptionType eType;
        public CensusAnalyserException(string message, ExceptionType exceptionType): base(message)
        {
            this.eType = exceptionType;
        }
          

    }
}

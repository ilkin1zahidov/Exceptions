using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exceptionss
{
   public class FindNameException : Exception
   {
        public FindNameException(string message):base(message)
        {

        }
   }
}

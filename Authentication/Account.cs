using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Authentication
{
    public class Account : Exception
    {
     
        public Account(string message):base(message)
        {
           

        }
    }
}

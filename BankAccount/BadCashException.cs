using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BadCashException: Exception
    {
        public BadCashException() : base("There are some counterfeit or bad notes in your account, transaction failure!") { }
        public BadCashException(string message) : base(message) { }
        public BadCashException(string message, Exception e) : base(message, e) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Alert
    {
        public void Action(object sender, BigMoneyFetchedEventArgs e)
        {
            Console.WriteLine("Your withdrawal amount is above the maximum limit of 10000.");
            Console.WriteLine("Pleas contact the bank teller or try another amount.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account{
        public string BankAccountNum { get; set; }
        public string BankInnerAccountNum { get; set; }
        public string Psw { get; set; }
        public string bankPsw { get; set; }
        public double Balance { get; set; }

        public void UserAccount(string BankAccountNum, string Psw, double Balance){
            this.BankAccountNum = BankAccountNum;
            this.Psw = Psw;
            this.Balance = Balance;
        }
        public void BankAccount(string BankInnerAccountNum, string bankPsw){
            this.BankInnerAccountNum = BankInnerAccountNum;
            this.bankPsw = bankPsw;
        }
        public double checkBalance()//查询余额
        {
            Console.WriteLine("Your balance is {0}", Balance);
            return Balance;

        }
        public void setBalance(double Balance)
        {
            this.Balance = Balance;
        }
        public string getUserAccount()
        {
            return BankAccountNum;
        }
        public void setUserAccount(string BankAccountNum)
        {
            this.BankAccountNum = BankAccountNum;
        }
        public string getPsw()
        {
            return Psw;
        }
        public string getBankPsw()
        {
            return bankPsw;
        }
        public void setPsw(string Psw)
        {
            this.Psw = Psw;
        }
        public bool depositBalance()//存钱
        {
            Random rnd1 = new Random();
            int Probability = rnd1.Next(4);
            Console.WriteLine("Please enter the deposit amount:");
            double depositAmount = double.Parse(Console.ReadLine());
            if (depositAmount <= 0)
            {
                Console.WriteLine("Insufficient deposit amount.");
                return false;
            }
            else
            {
                if (Probability<1)
                {
                    throw (new BadCashException());
                }
                else {
                    Balance += depositAmount;
                    Console.WriteLine("Successful deposit {0}, Your balance is {1}", depositAmount, Balance);
                }
                
                return true;
            }
            
        }
        private BigMoneyFetchedEventHandler BigMoneyFetchedEventHandler;
        public event BigMoneyFetchedEventHandler BigMoneyFetched{
            add
            {
                this.BigMoneyFetchedEventHandler += value;
            }
            remove
            {
                this.BigMoneyFetchedEventHandler -= value;
            }
        }
        public bool withdrawBalance(Account account,Alert alert)//取钱
        {
            Console.WriteLine("Please enter the withdrawal amount:");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            if (withdrawalAmount<10000&&withdrawalAmount>0)
            {
                if (withdrawalAmount > Balance)
                {
                    Console.WriteLine("Insufficient withdrawl amount.");
                    return false;
                }
                else
                {
                    Balance -= withdrawalAmount;
                    Console.WriteLine("Successfully withdrawl {0}, Your balance is {1}.", withdrawalAmount, Balance);
                    return true;
                }
            }
            else
            {
                account.BigMoneyFetched += alert.Action;
                if (this.BigMoneyFetchedEventHandler!=null)
                {
                    BigMoneyFetchedEventArgs e = new BigMoneyFetchedEventArgs();
                    e.WithdrawlMoney = withdrawalAmount;
                    e.CustomerID = account.getUserAccount();
                    this.BigMoneyFetchedEventHandler.Invoke(account, e);
                }
                return false;
            }
            
        }

        public void Transfer(Bank bank, string benefitAccountNum,double TransferAmount)//转账
        {
            Account benefitAccount = bank.FindAccount(benefitAccountNum);
            if (benefitAccount==null)
            {
                Console.WriteLine("The benefit account dose not exist.");
            }
            else
            {
                if (TransferAmount>this.Balance)
                {
                    Console.WriteLine("Your transfer amount is incorrect.");
                }
                else
                {
                    this.Balance -= TransferAmount;
                    benefitAccount.Balance += TransferAmount;
                    Console.WriteLine("You have successfully transferred {0} € to account {1}, your cuurent balance is {2}.",TransferAmount,benefitAccountNum,Balance);
                }
            }
        }
        public bool IsMatch(string BankAccountNum, string Psw)
        {
            return BankAccountNum == this.BankAccountNum && Psw == this.Psw;
        }
    }
    public delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyFetchedEventArgs e);//委托的声明
    public class BigMoneyFetchedEventArgs:EventArgs
    {
        public double WithdrawlMoney { get; set; }
        public string CustomerID { get; set; }
    }
}

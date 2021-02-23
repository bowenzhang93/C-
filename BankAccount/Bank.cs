using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bank
    {
        List<Account> accounts = new List<Account>();//用户账户列表
        List<Account> employeeAccounts = new List<Account>();//银行员工账户列表

        public Account OpenAccount(string BankAccountNum, string Psw, double Balance)//添加一个新账户
        {
            Account account = new Account();
            account.UserAccount(BankAccountNum, Psw, Balance);
            accounts.Add(account);
            return account;
        }

        public bool CloseAccount(Account account)//关闭一个账户
        {
            int idx = accounts.IndexOf(account);
            if (idx < 0)
            {
                return false;
            }
            accounts.Remove(account);
            return true;
        }

        public Account FindAccount(string searchedAccountNum)//查找一个账户
        {
            foreach (Account account in accounts)
            {
                if (searchedAccountNum == account.BankAccountNum)
                {
                    return account;
                }
            }
            return null;
        }

        //public bool BlockAccount(string BankAccountNum)//锁定一个账户
        //{
        //    Account BlockedAccount = FindAccount(BankAccountNum);
        //    if (BlockedAccount != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public Account OpenEmployeeAccount(string BankInnerAccountNum, string Psw)//添加一个银行新员工账户
        {
            Account employeeAccount = new Account();
            employeeAccount.BankAccount(BankInnerAccountNum, Psw);
            employeeAccounts.Add(employeeAccount);
            return employeeAccount;
        }

        public bool CloseEmployeeAccount(Account employeeAccount)//关闭一个银行新员工账户
        {
            int employeeidx = employeeAccounts.IndexOf(employeeAccount);
            if (employeeidx < 0)
            {
                return false;
            }
            accounts.Remove(employeeAccount);
            return true;
        }

        public Account FindEmployeeAccount(string BankInnerAccountNum)//查找一个银行新员工账户
        {
            foreach (Account employeeAccount in employeeAccounts)
            {
                if (BankInnerAccountNum == employeeAccount.BankInnerAccountNum)
                {
                    return employeeAccount;
                }
            }
            return null;
        }

        //public bool BlockEmployeeAccount(string BankInnerAccountNum)//锁定一个银行新员工账户
        //{
        //    Account BlockedAccount = FindAccount(BankInnerAccountNum);
        //    if (BlockedAccount != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

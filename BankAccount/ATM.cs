using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class ATM
    {
        public void ATMwelc(){
            Console.SetWindowSize(60, 20);
            Console.SetBufferSize(60, 20);
            Console.SetCursorPosition((60 - PublicStaticVariable.op3.Length) / 2, 2);
            Console.WriteLine(PublicStaticVariable.op3);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine(PublicStaticVariable.op1);
            Console.SetCursorPosition(60 - PublicStaticVariable.op2.Length, 8);
            Console.WriteLine(PublicStaticVariable.op2);
            Console.SetCursorPosition(0, 18);
            Console.WriteLine(PublicStaticVariable.op4);
            PublicStaticVariable.opSelected = Console.ReadLine();
            Console.Clear();
        }
        public void ATMcusprom()
        { 
            if (PublicStaticVariable.opSelected==1.ToString())
            {
                Console.SetCursorPosition((60 - PublicStaticVariable.str1.Length) / 2, 8);
                Console.WriteLine(PublicStaticVariable.str1);
                Console.SetCursorPosition((60 - 8) / 2, 9);
                PublicStaticVariable.UserId = Console.ReadLine();
                Console.SetCursorPosition((60 - PublicStaticVariable.str2.Length) / 2, 10);
                Console.WriteLine(PublicStaticVariable.str2);
                Console.SetCursorPosition((60 - 4) / 2, 11);
                ATMcuspass();
            }
            else if (PublicStaticVariable.opSelected==2.ToString())
            {
                Console.SetCursorPosition((60 - PublicStaticVariable.str1.Length) / 2, 8);
                Console.WriteLine(PublicStaticVariable.str1);
                Console.SetCursorPosition((60 - 8) / 2, 9);
                PublicStaticVariable.BankId = Console.ReadLine();
                Console.SetCursorPosition((60 - PublicStaticVariable.str2.Length) / 2, 10);
                Console.WriteLine(PublicStaticVariable.str2);
                Console.SetCursorPosition((60 - 4) / 2, 11);
                ATMemplpass();
            }
        }
        public void ATMcuspass()
        {
            PublicStaticVariable.input_Psw = null;
            while (true)
            {
                ConsoleKeyInfo ck = Console.ReadKey(true);//将输入的字符不显示在窗口上
                if (ck.Key != ConsoleKey.Enter)
                {
                    if (ck.Key != ConsoleKey.Backspace)//如果用户按下的不是删除键
                    {
                        PublicStaticVariable.input_Psw += ck.KeyChar.ToString();
                        Console.Write("*");//将用户的输入替换为*
                    }
                    else
                    {
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    Console.WriteLine();//
                    break;
                }
            }
            PublicStaticVariable.UserPsw = PublicStaticVariable.input_Psw;
        }
        public void ATMemplpass()
        {
            PublicStaticVariable.input_bankPsw = null;
            while (true)
            {
                ConsoleKeyInfo ck = Console.ReadKey(true);//将输入的字符不显示在窗口上
                if (ck.Key != ConsoleKey.Enter)
                {
                    if (ck.Key != ConsoleKey.Backspace)//如果用户按下的不是删除键
                    {
                        PublicStaticVariable.input_bankPsw += ck.KeyChar.ToString();
                        Console.Write("*");//将用户的输入替换为*
                    }
                    else
                    {
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    Console.WriteLine();//
                    break;
                }
            }
            PublicStaticVariable.BankPsw = PublicStaticVariable.input_bankPsw;
        }
        public bool CusIsMatch(Bank bank)
        {
            Account account = bank.FindAccount(PublicStaticVariable.UserId);
            if (account != null && PublicStaticVariable.UserPsw == account.getPsw())
            {
                Console.Clear();
                return true;
                //break;
            }
            else
            {
                Console.SetCursorPosition((60 - PublicStaticVariable.InputError.Length) / 2, 18);
                Console.WriteLine(PublicStaticVariable.InputError);
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public void NotMatch(string prompt)
        {
            int str_length = prompt.Length;
            int window_width = Console.WindowWidth;
            int len = str_length - window_width;
            Console.SetCursorPosition(0, 8);
            Console.Write(prompt.ToCharArray(0, window_width));
            Console.Write(prompt.ToCharArray(window_width + 1, len - 1));
            Console.ReadLine();
            return;//结束Main方法的执行，不再执行其下的语句了
        }
        public bool EmplIsMatch(Bank bank)
        {
            Account employeeAccount = bank.FindEmployeeAccount(PublicStaticVariable.BankId);
            if (employeeAccount != null && PublicStaticVariable.BankPsw == employeeAccount.getBankPsw())
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.SetCursorPosition((60 - PublicStaticVariable.InputError.Length) / 2, 18);
                Console.WriteLine(PublicStaticVariable.InputError);
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public void ATMcuslogin(Bank bank)
        {
            Alert alert = new Alert();
            Console.Clear();
            Console.SetCursorPosition((60 - PublicStaticVariable.Welcome.Length) / 2, 0);
            Console.WriteLine(PublicStaticVariable.Welcome);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("1.Deposit");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("2.Withdrawal");
            Console.SetCursorPosition(51, 2);
            Console.WriteLine("3.Enquiry");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("4.Transfer");
            Console.SetCursorPosition(54, 16);
            Console.WriteLine("5.Exit");

            Console.WriteLine("Please enter the service:");
            PublicStaticVariable.s = int.Parse(Console.ReadLine());
            Console.Clear();

            Account account = bank.FindAccount(PublicStaticVariable.UserId);
            //bank.FindAccount(UserId);
            switch (PublicStaticVariable.s)
            {
                case 1:
                    try
                    {
                        account.depositBalance();
                    }
                    catch(BadCashException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    account.withdrawBalance(account,alert);
                    Console.ReadKey();
                    break;
                case 3:
                    account.checkBalance();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Please enter the benefit account:");
                    string benefitAccount = Console.ReadLine();
                    Console.WriteLine("Your transfer amount:");
                    double transferAmount = double.Parse(Console.ReadLine());
                    account.Transfer(bank, benefitAccount, transferAmount);
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using this customer system. Goodbye!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public void ATMBankMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(PublicStaticVariable.s1);
            Console.SetCursorPosition(0, 7);
            Console.WriteLine(PublicStaticVariable.s2);
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(PublicStaticVariable.s3);
            Console.SetCursorPosition(60 - PublicStaticVariable.s4.Length, 2);
            Console.WriteLine(PublicStaticVariable.s4);
            Console.SetCursorPosition(60 - PublicStaticVariable.s5.Length, 7);
            Console.WriteLine(PublicStaticVariable.s5);
            Console.SetCursorPosition(60 - PublicStaticVariable.s6.Length, 12);
            Console.WriteLine(PublicStaticVariable.s6);
            Console.SetCursorPosition(60 - PublicStaticVariable.s7.Length, 17);
            Console.WriteLine(PublicStaticVariable.s7);
        }
        public void ATMBankService(Bank bank){
            Console.WriteLine("Please enter the service:");
            PublicStaticVariable.s_bank = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (PublicStaticVariable.s_bank){
                case 1:
                    string Num = "";
                    string Pass = "";
                    for (int i = 0; i < 8; i++)
                    {
                        Num += PublicStaticVariable.rnd.Next(10);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Pass += PublicStaticVariable.rnd.Next(10);
                    }
                    bank.OpenAccount(Num, Pass, 0);
                    Console.WriteLine("Account {0} has been opened, your password is: {1} ", Num, Pass);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Plese enter the account number:");
                    string accountClosed = Console.ReadLine();
                    bool delete_succ = bank.CloseAccount(bank.FindAccount(accountClosed));
                    if (delete_succ == true)
                    {
                        Console.WriteLine("The account {0} has been deleted.", accountClosed);
                    }
                    else
                    {
                        Console.WriteLine("Account {0} does not exist.", accountClosed);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Please enter the account number:");
                    string searched_ID = Console.ReadLine();
                    Account searched_Account = bank.FindAccount(searched_ID);
                    if (searched_Account != null)
                    {
                        Console.WriteLine("The searched account is {0}, the password is {1}", searched_Account.getUserAccount(), searched_Account.getPsw());
                    }
                    else
                    {
                        Console.WriteLine("Your searched account dose not exist.");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    string employeeNum = "";
                    string employeePass = "";
                    for (int i = 0; i < 8; i++)
                    {
                        employeeNum += PublicStaticVariable.rnd.Next(10);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        employeePass += PublicStaticVariable.rnd.Next(10);
                    }
                    bank.OpenEmployeeAccount(employeeNum, employeePass);
                    Console.WriteLine("Employee account {0} has been opened, your password is: {1} ", employeeNum, employeePass);
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Plese enter the employee account number:");
                    string employeeAccountClosed = Console.ReadLine();
                    if (employeeAccountClosed == "20210102")
                    {
                        Console.WriteLine("Administrator account cannot be delected!");
                    }
                    else
                    {
                        bool delete_succ_emplo = bank.CloseEmployeeAccount(bank.FindAccount(employeeAccountClosed));
                        if (delete_succ_emplo == true)
                        {
                            Console.WriteLine("The employee account {0} has been deleted.", employeeAccountClosed);
                        }
                        else
                        {
                            Console.WriteLine("Employee account {0} does not exist.", employeeAccountClosed);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Please enter the employee account number:");
                    string searched_EmploID = Console.ReadLine();
                    Account searched_EmploAccount = bank.FindEmployeeAccount(searched_EmploID);
                    if (searched_EmploAccount != null)
                    {
                        Console.WriteLine("The searched employee account is {0}, the password is {1}", searched_EmploAccount.getUserAccount(), searched_EmploAccount.getPsw());
                    }
                    else
                    {
                        Console.WriteLine("Your searched employee account dose not exist.");
                    }
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Thank you for using this employee system. Goodbye!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}

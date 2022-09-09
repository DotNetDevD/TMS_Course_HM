using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_DelegatePractice
{
    internal class CreditCard_Delegate
    {
        public int Sum { get; private set; }
        public AccountAction? Notify;
        public void Handler(AccountAction? someAction)
        {
            Notify = someAction;
        }
        public CreditCard_Delegate(int sum)
        {
            Sum = sum;
        }
        public void Put(int sum)
        {
            Sum += sum;
            Console.ForegroundColor = ConsoleColor.Green;
            Notify?.Invoke($"Account replenishment was successful: {sum}");
            Console.ResetColor();
            Notify?.Invoke($"Balance: {Sum}");
        }
        public void Get(int sum)
        {
            if (Sum > sum)
            {
                Sum -= sum;
                Console.ForegroundColor = ConsoleColor.Green;
                Notify?.Invoke($"Account withdrawal was successful: {sum}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Notify?.Invoke($"Withdrawal request failure: not enough available funds: {sum}");
                Console.ResetColor();
            }
            Notify?.Invoke($"Balance: {Sum}");
        }
    }
}


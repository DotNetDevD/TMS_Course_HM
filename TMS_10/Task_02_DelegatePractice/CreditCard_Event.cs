using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_DelegatePractice
{
    public delegate void AccountAction(string message);
    internal class CreditCard_Event
    {
        public int Sum { get; private set; }
        public event AccountAction? Notify;

        public CreditCard_Event(int sum)
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
//Создать класс CreditCard. В классе создать два метода Put - положить деньги на карту,
//Get - снять деньги с карты. В классе создать элемент AccountAction. Класс реализовать двумя способами: 
//когда AccountAction экземпляр делегата; когда AccountAction событие.
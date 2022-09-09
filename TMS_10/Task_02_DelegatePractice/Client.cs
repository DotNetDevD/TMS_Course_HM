using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_DelegatePractice
{
    internal class Client
    {
        public void ClientAction(string message) => Console.WriteLine(message);
    }
}
// Создать класс Client. В классе создать метод, который будет использован для передачи в экземпляр делегат/событие.
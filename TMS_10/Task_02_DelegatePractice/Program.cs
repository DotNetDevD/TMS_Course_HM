using Task_02_DelegatePractice;

Client client = new Client();

//Action with Event
//CreditCard_Event creditCardAction = new(100);
//creditCardAction.Notify += client.ClientAction;

//Action with Delegate
CreditCard_Delegate creditCardAction = new(100);
creditCardAction.Handler(client.ClientAction);

creditCardAction.Put(10);
creditCardAction.Get(50);
creditCardAction.Get(200);

creditCardAction.Notify += message =>
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Add lambda expression");
    Console.ResetColor();
};
creditCardAction.Notify += delegate (string message)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Add anonymous function");
    Console.ResetColor();
};
creditCardAction.Put(10);
creditCardAction.Get(50);


/*
В методе main создать экземпляр класса CreditCard, создать экземпляр класса Client. Client должен подписаться  
на делегат/событие AccountAction экземпляра класса CreditCard. Вызвать методы Put, Get, проанализировать результаты, 
сделать выводы. Добавить в делегат/событие AccountAction анонимный метод, лямбда-выражение.  Вызвать методы Put, Get, 
проанализировать результаты, сделать выводы.
*/


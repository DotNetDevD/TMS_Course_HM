namespace Task_01
{
    internal class Program
    {

        static ExchangeRate[] CreateExchangeRateArray(Currencies userCurrencies)
        {
            ExchangeRate[] exchangeRateArray = new ExchangeRate[10];

            Currencies currencies = new Currencies();

            Random rand = new Random();

            for (int i = 0; i < exchangeRateArray.Length; i++)
            {
                currencies = (Currencies)i;
                double randomCourse = rand.NextDouble() * 5;
                if (currencies == userCurrencies) { randomCourse = 1; }
                ExchangeRate exchangeRate = new(userCurrencies, currencies, randomCourse);
                exchangeRateArray[i] = exchangeRate;
            }

            return exchangeRateArray;
        }

        static ExchangeRate CreateExchangeRate()
        {
            Random rand = new Random();
            double randomCourse = rand.NextDouble() * 5;

            Currencies currencies1 = (Currencies)rand.Next(10);
            Currencies currencies2 = (Currencies)rand.Next(10);

            if (currencies1 == currencies2) randomCourse = 1;

            ExchangeRate exchangeRate = new ExchangeRate(currencies1, currencies2, randomCourse);

            return exchangeRate;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Валютный калькулятор");
            CurrencyConverter currencyConverter = new();
            Console.WriteLine("Введите валюту которую хотите обьменять: ");

            currencyConverter.AddExchangeRates(CreateExchangeRateArray(Currencies.RUB));
            Console.Write("");
            Console.ReadLine();
            Console.Write("Введите валюту на которую хотите обьменять: ");
            Console.WriteLine("USD");
            Console.Write("Курс на данный момент: ");
            ExchangeRate findExchangeRate = cc.FindExchangeRate(Currencies.EUR, Currencies.USD);
            Console.WriteLine(findExchangeRate);
            Console.Write("Сумма на обмен: ");
            Console.WriteLine(10);
            Console.Write("Ваш обмен: ");
            ExchangeRate myExchange = cc.Convert(Currencies.EUR, Currencies.USD, 10);
            Console.Write(myExchange);
            Console.WriteLine();
        }
    }
}
/*
4. Написать валютный калькулятор:
 4.1 Программа должна обладать следующим функционалом:
   - Программа должна создавать CurrencyConverter с разными курсами валют(СurrencyConverter.AddExchangeRate()). 
Можно добавить до 10 разных курсов, придумать самим
   - Отображать пользователю имеющиеся курсы - CurrencyConverter.ToString()
   - Конвертировать валюты и отображать полученный результат - пользователь вводит название валюты, 
название валюты в которую необходимо выполнить конвертацию и значение, указывающие объем первой валюты

 4.2 Программа должна содержать следующие сущности (каждая сущность в отдельном классе):
    - Перечисление Currencies – можно добавить до 10 разных валют.
  
    - Класс ExchangeRate. 
Поля класса: Currencies FirstCurrency, Currencies SecondCurrency, float Value, int CurrencyCount = 1. 
Методы: public override string ToString() 
(данный метод должен возвращать строку в следующем виде “{CurrencyCount} {FirstCurrency} = {Value} {SecondCurrency}”,
например “1,00 USD = 36,76 RUB “, значения CurrencyCount и Value должно отображаться с точностью до двух знаков после 
запятой); Конструктор, который принимает  либо два параметра типа Currencies, 
либо три параметра  - Currencies, Currencies, float, в конструкторе установить значения полей; 
SetValue(float value), который будет изменять значение поля Value; SetCount(int count), 
который будет изменять значение поля CurrencyCount.

    - Класс CurrencyConverter. Поля:  List<ExchangeRate> ExchangeRates, которое должно инициализироваться в конструкторе.
Методы: 
 * AddExchangeRate(ExchangeRate) и AddExchangeRates(ExchangeRate[])  – добавление экземпляров ExchangeRate 
в список List<ExchangeRate>; 
 * TryDeleteExchangeRate(Currencies firstCurrency, Currencies secondCurrency) – попытка найти и удалить ExchangeRate 
из ExchangeRates; 
 * FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency) поиск в ExchangeRates; 
 * public override string ToString() – метод должен выводить список всех курсов, которые хранятся 
в ExchangeRates (необходимо использовать StringBuilder и цикл foreach); 
 * Convert(Currcencies CurrcencyFirst, Currencies CurrencySecond,  int count) – метод выполняет поиск поиск нужного 
ExchangeRate в List<ExchangeRate>, делает конвертацию валют и возвращает новый ExchangeRate 
с установленными FirstCyrrency, SecondCurrency, Value, Count.
*/

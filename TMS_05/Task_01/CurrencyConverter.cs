using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class CurrencyConverter
    {
        private List<ExchangeRate> _exchangeRates;

        public CurrencyConverter()
        {
            _exchangeRates = new List<ExchangeRate>();
        }

        // добавление экземплярa ExchangeRate в список List<ExchangeRate>
        public void AddExchangeRate(ExchangeRate exchangeRate)
        {
            _exchangeRates.Add(exchangeRate);
        }

        // добавление массива экземпляров ExchangeRate[] в список List<ExchangeRate>
        public void AddExchangeRates(ExchangeRate[] exchangeRates)
        {
            foreach (var exchangeRate in exchangeRates)
            {
                _exchangeRates.Add(exchangeRate);
            }
        }

        // попытка найти и удалить ExchangeRate из ExchangeRates
        public void TryDeleteExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            for (int i = 0; i < _exchangeRates.Count; i++)
            {
                if (_exchangeRates[i].FirstCurrency == firstCurrency &&
                   _exchangeRates[i].SecondCurrency == secondCurrency)
                {
                    _exchangeRates.Remove(_exchangeRates[i]);
                }
            }
            /* Почему данный способ не работает, если код одинaковый?
            foreach (var exchangeRate in _exchangeRates)
            {
                if (exchangeRate.FirstCurrency == firstCurrency &&
                   exchangeRate.SecondCurrency == secondCurrency)
                {
                    _exchangeRates.Remove(exchangeRate);
                }
            */
        }

        // поиск в ExchangeRates
        public ExchangeRate FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            ExchangeRate findExchangeRate = null;
            foreach (var exchangeRate in _exchangeRates)
            {
                if (exchangeRate.FirstCurrency == firstCurrency &&
                   exchangeRate.SecondCurrency == secondCurrency)
                {
                    findExchangeRate = exchangeRate;
                }
            }
            return findExchangeRate;
        }

        // метод выполняет поиск нужного ExchangeRate в List<ExchangeRate>,
        // делает конвертацию валют и возвращает новый ExchangeRate
        // с установленными FirstCyrrency, SecondCurrency, Value, Count.
        public ExchangeRate Convert(Currencies currcencyFirst, Currencies currencySecond, int count)
        {
            ExchangeRate findExchangeRate = FindExchangeRate(currcencyFirst, currencySecond);
            ExchangeRate myExchange = new(currcencyFirst, currencySecond);
            myExchange.СurrencyCount = count;
            myExchange.Value = Math.Round(count * findExchangeRate.Value, 2);
            return myExchange;
        }

        // Вывод список всех курсов, которые хранятся в ExchangeRates
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var exchangeRate in _exchangeRates)
            {
                sb.Append(exchangeRate + "\n");
            }
            return sb.ToString();
        }

    }
}
/*
 - Класс CurrencyConverter. 
Поля:  
 * List<ExchangeRate> ExchangeRates, которое должно инициализироваться в конструкторе.
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
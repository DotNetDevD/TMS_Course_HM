using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class ExchangeRate
    {
        Currencies _firstCurrency;
        Currencies _secondCurrency;

        private double _value;
        private int _currencyCount = 1;

        // Конструктор, который принимает два параметра типа Currencies 
        public ExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            _firstCurrency = firstCurrency;
            _secondCurrency = secondCurrency;
        }

        // Конструктор, который принимает два параметра типа Currencies и value;
        public ExchangeRate(Currencies firstCurrency, Currencies secondCurrency, double value) 
            : this(firstCurrency, secondCurrency)
        {
            _value = value;
        }

        public override string ToString()
        {
            string currencyFormat = string.Format("{0:F2}", _currencyCount);
            string valueFormat = string.Format("{0:F2}", _value);
            string result = $"{currencyFormat} {_firstCurrency} = {valueFormat} {_secondCurrency}";
            return result;
        }

        // Свойство только для записи значения поля _value (вместо метода SetValue)
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        // Свойство только для записи значения поля _currencyCount (вместо метода SetCount)
        public int СurrencyCount
        {
            set { _currencyCount = value; }
        }

        public Currencies FirstCurrency => _firstCurrency;
        public Currencies SecondCurrency => _secondCurrency;

    }
}
/*
Поля класса: 
 * Currencies FirstCurrency, 
 * Currencies SecondCurrency, 
 * double Value, 
 * int CurrencyCount = 1. 
Методы: 
 * public override string ToString() 
(данный метод должен возвращать строку в следующем виде “{CurrencyCount} {FirstCurrency} = {Value} {SecondCurrency}”,
например “1,00 USD = 36,76 RUB“, значения CurrencyCount и Value должно отображаться с точностью до двух знаков после 
запятой); 
 * Конструктор, который принимает  либо два параметра типа Currencies, 
   либо три параметра  - Currencies, Currencies, double, в конструкторе установить значения полей; 
 * SetValue(float value), который будет изменять значение поля Value; 
 * SetCount(int count), который будет изменять значение поля CurrencyCount.
 */
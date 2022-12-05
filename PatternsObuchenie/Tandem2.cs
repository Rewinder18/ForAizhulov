using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    internal interface IStrategy
    {
        string DoSomething();
    }

    internal class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomething()
        {
            if (this._strategy != null)
            {
                this._strategy.DoSomething();
            }
        }
    }
    interface Product
    {

    }
    class ProductScuderia:Product
    {
    }
    class ProductRedbull:Product
    {
    }
    abstract class Creator
    {
        public abstract Product FactoryMeth();
    }
    internal class FirstStrategy : Creator, IStrategy
    {
        //Создание объекта первой фабрики
        public override Product FactoryMeth()
        {
            return new ProductScuderia();
        }
        public string DoSomething()
        {
            return ""; //Возвращение строчки состоящей из HTML кода (пока, хезе чего)
        }
    }

    internal class SecondStrategy : Creator, IStrategy
    {
        //Создание объекта второй фабрики
        public override Product FactoryMeth()
        {
            return new ProductRedbull();
        }
        public string DoSomething()
        {
            //Создание первого продукта и вызов его метода
            return ""; //Возвращение строчки состоящей из HTML кода (пока, хезе чего)
        }
    }
}

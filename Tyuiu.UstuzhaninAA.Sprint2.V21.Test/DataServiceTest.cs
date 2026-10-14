using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task1.V21.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            
            DataService ds = new DataService();
            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            // Тестирующий метод
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            // Ожидаемый массив
            bool[] wait = new bool[] { false, false, false, false, true, false };

            //Проверка
            CollectionAssert.AreEqual(wait, res, "Полученный массив логических значений не совпадает с ожидаемым.");
        }
    }
}

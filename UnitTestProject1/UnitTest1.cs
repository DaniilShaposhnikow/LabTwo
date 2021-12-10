using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp8;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var table = new ConsoleApp8.HashTable(13);
            table.Add(55);
            table.Add(1);
            table.Add(3);
            table.Add(124);


            var chectTable = new List<List<int>>();
            chectTable.Add(new List<int>()); //0
            chectTable.Add(new List<int>() {1 }); //1
            chectTable.Add(new List<int>()); //2
            chectTable.Add(new List<int>() {3, 55 }); //3
            chectTable.Add(new List<int>()); //4
            chectTable.Add(new List<int>()); //5
            chectTable.Add(new List<int>()); //6
            chectTable.Add(new List<int>() {124 }); //7
            chectTable.Add(new List<int>()); //8
            chectTable.Add(new List<int>()); //9
            chectTable.Add(new List<int>()); //10
            chectTable.Add(new List<int>()); //11
            chectTable.Add(new List<int>()); //12

            for (int i = 0; i < table.Table.Count; i++)
            {
                Console.Write($"{i}: ");
                Print(chectTable[i]);
                Console.Write($"{i}: ");
                Print(table.Table[i]);
                //Assert.AreEqual(chectTable[i], table.Table[i]);
            }

            for (int i = 0; i < table.Table.Count; i++)
            {
                Assert.AreEqual(chectTable[i], table.Table[i]);
            }

        }

        private void Print (List<int> str)
        {
            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{str[i]} ");
            }
            Console.WriteLine();
        }
    }
}

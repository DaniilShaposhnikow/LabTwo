using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class HashTable
    {
        private int kod;

        private List<List<int>> table;

        public HashTable (int newKod)
        {
            kod = newKod;

            table = new List<List<int>>();
            for (int i = 0; i < kod; i++)
            {
                table.Add(new List<int>());
            }
        }

        public void Add (int num)
        {
            int kodThisNum = num % kod;
            if (table[kodThisNum].Count > 0)
            {
                Step(kodThisNum);
                table[kodThisNum][0] = num;
            } else
            {
                table[kodThisNum].Add(num);
            }
        } 

        private void Step (int thisKod)
        {
            
            var newNum = table[thisKod][table[thisKod].Count - 1];
            table[thisKod].Add(newNum);
            for (int i = table[thisKod].Count - 2; i > 0; i--)
            {
                table[thisKod][i + 1] = table[thisKod][i];
            }

        }

        public bool Delete (int num)
        {
            int kodThisNum = num % kod;
                     
            int i;
            for (i = 0; num != table[kodThisNum][i]; i++) { }
            if (num == table[kodThisNum][i])
            {
                table[kodThisNum].RemoveAt(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int x;

        public int y;

        public bool Find(int num)
        {
            int kodThisNum = num % kod;

            int i;
            for (i = 0; num != table[kodThisNum][i]; i++) { }
            if (num == table[kodThisNum][i])
            {
                x = kodThisNum;
                y = i;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void PrintAllTable ()
        {
            for (int i = 0; i < table.Count; i++)
            {
                Console.Write($"{i}:");
                for (int j = 0; j < table[i].Count; j++)
                {
                    Console.Write($" {table[i][j]}");
                }
                Console.WriteLine();
            }
        }

        public List<List<int>> Table 
        {
            get 
            {
                return table;
            }
        }
    }
}
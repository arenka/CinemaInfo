using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaInfo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan istenilen bilgilere göre işlem yapak için;
            //int diagonalLen = 0;
            //List<List<int>> records = new List<List<int>>();
            //Console.Write("Matris kare sayısı giriniz : ");
            //diagonalLen = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < diagonalLen; i++)
            //{
            //    List<int> list1 = new List<int>();
            //    for (int j = 0; j < diagonalLen; j++)
            //    {
            //        Console.Write($"{i + 1}. sıra {j + 1}.sayı giriniz: ");
            //        list1.Add(Convert.ToInt32(Console.ReadLine()));
            //    }
            //    records.Add(list1);
            //}


            //Verilen bir matris üzerinde işlem yapmak için;

            List<List<int>> records = new List<List<int>>() {
            new List<int> { 1, 4,7},
            new List<int> { 2, 6,9},
            new List<int> { 8, 4,3}
            };

            var result = Foo(records);
            System.Console.WriteLine(result);

            System.Console.ReadLine();
        }


        static int Foo(List<List<int>> records)
        {
            int sum1 = 0, sum2 = 0;

            System.Console.Write("Matris :\n");
            foreach (var record in records)
            {
                foreach (var number in record)
                {
                    System.Console.Write("{0}  ", number.ToString());
                }
                System.Console.Write("\n");
            }

            int firstColumnNumber = 0;
            int secondColumnNumber = records.Count;
            foreach (var item in records)
            {
                secondColumnNumber = secondColumnNumber - 1;
                for (int i = 0; i < item.Count; i++)
                {
                    if (i == firstColumnNumber)
                    {
                        sum1 = sum1 + item[i];
                    }
                    if (i == secondColumnNumber)
                    {
                        sum2 = sum2 + item[i];
                    }
                }
                firstColumnNumber++;
            }
            int absoluteValue = Math.Abs(sum1 - sum2);
            return absoluteValue;
        }
    }
}

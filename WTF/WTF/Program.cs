using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WTF
{
    class Program
    {
        static void Main(string[] args)
        {
            //кол-во сотрудников чей возраст кратен 3

            List<int> age = new List<int>();

            StreamReader sr = File.OpenText("humans.txt");
            string rl = "";

            while((rl = sr.ReadLine()) != null)
            {
                string[] words = rl.Split(new char[] { ' ' });
                age.Add(int.Parse(words[3]));
            }
            try
            {
                var findold = age.Where(a => a % 3 == 0);
                foreach (int a in findold)
                    Console.WriteLine(findold);
            }
            catch
            {
                Console.WriteLine("Некоректные данные");
            }
            sr.Close();

            /*
            Console.WriteLine("Кол-во чисел в массиве: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double[] numbs = new double[a];
            Console.WriteLine("Введите числа: ");
            for (int i = 0; i < a; i++)
            {
                numbs[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Разность чисел массива: " + numbs.Aggregate((x,y) => x - y));
            */
        }
    }
}

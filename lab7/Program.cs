using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
	    Console.WriteLine("Введите строку для сортировки");
            char[] str = Console.ReadLine().ToCharArray();
            Array.Sort(str);

	    Console.WriteLine("Отсортированая строка");
            Console.WriteLine(new String(str));
            Console.ReadKey();
        }
    }
}

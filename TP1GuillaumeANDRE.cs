using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Transactions;

//Guillaume ANDRE
//M1 ITF

//Exercice 1 :

namespace Tables
{
    class Program
    {
        //1.1
        static void Main(string[] args)
        {
            table();
            AskUserForParameter();
        }

        public static void table()
        {
            int table = 0;
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    table = i * j;
                    //if (table % 2 == 1) ---> 1.2
                    Console.WriteLine(i + "x" + j + "=" + table);
                }
            }
        }


        //1.3
        public static int AskUserForParameter()
        {
            Console.Write("veuillez choisir votre i :");
            var i = Console.ReadLine();
            Console.WriteLine(i);
            Console.Write("veuillez choisir votre j :");
            var j = Console.ReadLine();
            Console.WriteLine(j);
            var resultmult = int.Parse(i) * int.Parse(j);
            Console.WriteLine(resultmult.ToString());



            return resultmult;
        }
    }
} //fin exo 1




// Exercice 2 :

namespace PrimeFiboFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //2.1
    namespace PrimeNumber
    {
        class Program
        {
            static void Main(string[] args)
            {
                bool isPrime = true;
                Console.WriteLine("Prime Numbers : ");
                for (int i = 2; i <= 100; i++)
                {
                    for (int j = 2; j <= 100; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.Write("\t" + i);
                    }
                    isPrime = true;
                }
                Console.ReadKey();
            }


        }
    }


    //2.2
    namespace Fibo
    {
        class Program
        {
            public static int Fib(int n)
            {
                if (n <= 1)
                {
                    return 1;
                }
                else
                {
                    return Fib(n - 1) + Fib(n - 2);
                }
            }
            public static void Main(string[] args)
            {
                int n = 9;
                Console.Write(Fib(n));
            }
        }
    }

    //2.3

    namespace Factorial
    {
        class Program
        {

            public static void Main(string[] args)
            {
                int i, fact = 1, number;
                Console.Write("Enter any Number: ");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);

                //choose input 4 and 6 for a. & b.

                //c. What would happen if you tried to calculate 420.000!?
                // Don't works because our laptop tools are not power enough to calculate this.

                //d. Theorical: what is recursive function?
                //Calculable functions, i.e. functions whose values can be calculated from their parameters by a finite mechanical process.
            }
        }
    }


} //Fin exo 2




// Exercice 3 :

namespace Trycatch
{

    class Program
    {
        static void Main(string[] args)
        {
            PowerF(3);
            PowerF(-2);
        }
        private static void PowerF(int x)
        {
            try
            {
                Console.WriteLine(10 / PowerFunction(x));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division By Zero");
            }
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

    }
}

//Exercice 4 :

namespace square
{

    class Program
    {
        static void Main(string[] args)
        {
            Square(3,4);
        }

        private static void Square(int N, int M)
        {
            if (N >= 2)
            {
                string horiz = new string('-', N - 2);
                horiz = "0" + horiz + "0";
                Console.WriteLine(horiz);
                for (int i = 1; i < M - 1; i++)
                {
                    string verti = new string(' ', N - 2);
                    verti = "|" + verti + "|";
                    Console.WriteLine(verti);
                }
                if (M > 1)
                {
                    Console.WriteLine(horiz);
                }
            }
            else
            {
                Console.WriteLine("0");
                for (int i = 1; i < M - 1; i++)
                {
                    Console.WriteLine("|");
                }
                if (M > 1)
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}



//Exercice 5 :

namespace Tree
{

    class Program
    {
        static void Main(string[] args)
        {
            Regulartree(13);
        }

        public static void Regulartree(int size)
        {
            List<String> tree = new List<String>();
            for (int i = 0; i < size - 1; i++)
            {
                string branche = new string('*', i);
                string sapin = branche + branche;
                sapin += '*';
                string str1 = new string(' ', size - 1 - i);
                string str2 = str1 + sapin;
                tree.Add(str2);
            }
            foreach (string a in tree)
            {
                Console.WriteLine(a);
            }
            string t = new string(' ', size - 2);
            string tronc = t + '|' + ' ' + '|';
            Console.WriteLine(tronc);

        }
    }
}
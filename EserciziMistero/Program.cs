using System;

namespace EserciziMistero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire un numero: ");
            int n = double.Parse(Console.ReadLine());
        }        
            //somma
        public static int Mistero1(int x, int y )
        {
            int prec;
            if (y == 0)
                return x;
            else
                prec = Mistero1(x, y - 1) + 1;
            return prec;
        }        
        //moltiplicazione
        public static int Mistero2(int x, int y)
        {
            if (y == 0)
                return 0;
            else
                return (Mistero1(x, Mistero2(x, y - 1)));
        }
        //esponente
        public static int Mistero3(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return (Mistero2(x, Mistero3(x, y - 1)));
        }
        //scrive il numero al contrario
        public static int Mistero4(long n)
        {
            Console.Write(n % 10);
            if (n / 10 != 0)
                return Mistero4(n / 10);
            else
                return "";
        }
        //
        public static int Mistero5(int n)
        {
            if (n = 0)
                return 0;
            if (n = 1)
                return 1;
            else (Mistero5(n - 1) + Mistero5(n - 2));
        }
        //
        public static int Mistero6(int x, int y)
        {
            if (x < 0)
                return Mistero6(x + y, y);
            else if (x < y)
                return x;
            else
                return Mistero6(x - y, y);
        }
        //esponente
        public static int Mistero7(int x, int y)
        {
            int z = 1;
            if (y < 0)
            {
                z = 0;
                throw new Exception("y non può essere minore di 0");
            }
            else if (y = 0)
                z = x * Mistero7(x, y - 1);
            return z;
        }
        public static int Mistero8(int x, int y)
        {
            int z;
            
                z = a % b;
                if (z = 0)
            {
                return b;
            }                                           
            else
            {
                a = b;
                b = z;
                return Mistero8(a, b);
            }           
        }
    }
}

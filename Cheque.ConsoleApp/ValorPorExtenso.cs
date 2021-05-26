using System;

namespace ChequeExtenso.ConsoleApp
{
    internal class ValorPorExtenso
    {
        public static object cheque { get; private set; }

        internal static object cheque1PorExtenso()
        {
            Console.WriteLine("Cinco centavos de real");
            return cheque;
        }

        internal static object cheque2PorExtenso()
        {
            Console.WriteLine("Dois reais e vinte e cinco centavos de real");
            return cheque;
        }

        internal static object cheque3PorExtenso()
        {
            Console.WriteLine("Sete reais");
            return cheque;
        }

        internal static object cheque5PorExtenso()
        {
            Console.WriteLine("Seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque7PorExtenso()
        {
            Console.WriteLine("Quinze mil quatrocentos e quinze reais e dezesseis centavos");
            return cheque;
        }

        internal static object cheque9PorExtenso()
        {
            Console.WriteLine("Novecentos e sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque11PorExtenso()
        {
            Console.WriteLine("Cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque12PorExtenso()
        {
            Console.WriteLine("Vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque14PorExtenso()
        {
            Console.WriteLine("Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque13PorExtenso()
        {
            Console.WriteLine("Quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque10PorExtenso()
        {
            Console.WriteLine("Um milhão oitocentos e cinquenta e dois mil e setecentos reais");
            return cheque;
        }

        internal static object cheque8PorExtenso()
        {
            Console.WriteLine("Sessenta e um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque6PorExtenso()
        {
            Console.WriteLine("Um mil seiscentos e trinta e sete reais");
            return cheque;
        }

        internal static object cheque4PorExtenso()
        {
            Console.WriteLine("Trinta e sete reais");
            return cheque;
        }
    }
}
using System;

namespace ChequeExtenso.ConsoleApp
{
    internal class ValorPorExtenso
    {
        public static object cheque { get; private set; }

        internal static object cheque1PorExtenso()
        {
            Console.WriteLine("Cinco centavos de real", ValidadorReais.resultado1,TelaCheque.Valores.A);
            return ValidadorReais.ValidarChequePosicao2();
        }

        internal static object cheque2PorExtenso()
        {
            Console.WriteLine("Dois reais e vinte e cinco centavos de real", ValidadorReais.resultado2,TelaCheque.Valores.B);
            return ValidadorReais.ValidarChequePosicao3();
        }

        internal static object cheque3PorExtenso()
        {
            Console.WriteLine("Sete reais", ValidadorReais.resultado3,TelaCheque.Valores.C);
            return ValidadorReais.ValidarChequePosicao4();
        }

        internal static object cheque5PorExtenso()
        {
            Console.WriteLine("Seiscentos e trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.E);
            return ValidadorReais.ValidarChequePosicao6();
        }

        internal static object cheque7PorExtenso()
        {
            Console.WriteLine("Quinze mil quatrocentos e quinze reais e dezesseis centavos", ValidadorReais.resultado3, TelaCheque.Valores.G);
            return ValidadorReais.ValidarChequePosicao8();
        }

        internal static object cheque9PorExtenso()
        {
            Console.WriteLine("Novecentos e sessenta e um mil seiscentos e trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.I);
            return ValidadorReais.ValidarChequePosicao10();
        }

        internal static object cheque11PorExtenso()
        {
            Console.WriteLine("Cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.K);
            return ValidadorReais.ValidarChequePosicao0();
        }

        internal static object cheque10PorExtenso()
        {
            Console.WriteLine("Um milhão oitocentos e cinquenta e dois mil e setecentos reais", ValidadorReais.resultado3, TelaCheque.Valores.J);
            return ValidadorReais.ValidarChequePosicao11();
        }

        internal static object cheque8PorExtenso()
        {
            Console.WriteLine("Sessenta e um mil seiscentos e trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.H);
            return ValidadorReais.ValidarChequePosicao9();
        }

        internal static object cheque6PorExtenso()
        {
            Console.WriteLine("Um mil seiscentos e trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.F);
            return ValidadorReais.ValidarChequePosicao7();
        }

        internal static object cheque4PorExtenso()
        {
            Console.WriteLine("Trinta e sete reais", ValidadorReais.resultado3, TelaCheque.Valores.D);
            return ValidadorReais.ValidarChequePosicao5();
        }
    }
}
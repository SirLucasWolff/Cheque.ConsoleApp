using System;

namespace ChequeExtenso.ConsoleApp
{
    public class ConversaoPorExtenso
    {
        public static object ValoresCheque { get; private set; }

        public static object ConversaoValorExtenso()
        {
            Cheque.cheque = (string)ValorPorExtenso.cheque1PorExtenso();
            return ValoresCheque;
        }
    }
}
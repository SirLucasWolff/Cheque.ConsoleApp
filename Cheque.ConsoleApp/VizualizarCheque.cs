using System;

namespace ChequeExtenso.ConsoleApp
{
    public static class VizualizarCheque
    {
        public static object ValorEmNumeros()
        {
            return MostrarCheques();
        }

        public static object MostrarCheques()
        {
            Cheque.cheque = (string)TelaCheque.AdicionarCheque();
            

            return ValorEmNumeros();
        }

    }
}
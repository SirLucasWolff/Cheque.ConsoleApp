using System;
using System.Collections.Generic;
using System.Linq;

namespace ChequeExtenso.ConsoleApp
{
    public static class TelaCheque
    {
        public static object ValidarReais;

        public static object AdicionarCheque()
        {
            int[] Cheque = new int[55];
            List<int> Valores = new List<int>();

            Valores.Add(005);
            Valores.Add(225);
            Valores.Add(700);
            Valores.Add(3700);
            Valores.Add(63700);
            Valores.Add(163700);
            Valores.Add(1541516);
            Valores.Add(6163700);
            Valores.Add(96163700);
            Valores.Add(185270000);
            Valores.Add(596163700);
            Valores.Add(259616370);

            Valores.CopyTo(Cheque, 0);

            if (Valores.Contains(0))
            {
                return true;
            }
            else
            {
                return false;
            }

            Validador(Cheque);

            return AdicionarCheque();
        }

        private static void Validador(int[] Cheque)
        {
            Cheque[0] = ValidadorReais.ValidarChequePosicao0();
            Cheque[1] = ValidadorReais.ValidarChequePosicao1();
            Cheque[2] = ValidadorReais.ValidarChequePosicao2();
            Cheque[3] = ValidadorReais.ValidarChequePosicao3();
            Cheque[4] = ValidadorReais.ValidarChequePosicao4();
            Cheque[5] = ValidadorReais.ValidarChequePosicao5();
            Cheque[6] = ValidadorReais.ValidarChequePosicao6();
            Cheque[7] = ValidadorReais.ValidarChequePosicao7();
            Cheque[8] = ValidadorReais.ValidarChequePosicao8();
            Cheque[9] = ValidadorReais.ValidarChequePosicao9();
            Cheque[10] = ValidadorReais.ValidarChequePosicao10();
            Cheque[11] = ValidadorReais.ValidarChequePosicao11();
            Cheque[12] = ValidadorReais.ValidarChequePosicao12();
            Cheque[13] = ValidadorReais.ValidarChequePosicao13();
        }

        internal static string MostrarCheque()
        {
            throw new NotImplementedException();
        }
    }
}
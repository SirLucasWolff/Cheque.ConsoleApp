using System;
using System.Collections.Generic;
using System.Linq;

namespace ChequeExtenso.ConsoleApp
{
    public static class TelaCheque
    {
        public static object ValidarReais;

        public enum Valores
        {
            A = 050,
            B = 225,
            C = 700,
            D = 3700,
            E = 63700,
            F = 163700,
            G = 1541516,
            H = 6163700,
            I = 96163700,
            J = 185270000,
            K = 596163700,
        }
      
        public static string MostrarCheque()
        {
            Valores.A.GetHashCode();
            Valores.B.GetHashCode();
            Valores.C.GetHashCode();
            Valores.D.GetHashCode();
            Valores.E.GetHashCode();
            Valores.F.GetHashCode();
            Valores.G.GetHashCode();
            Valores.H.GetHashCode();
            Valores.I.GetHashCode();
            Valores.J.GetHashCode();
            Valores.K.GetHashCode();

            int nomes = ValidadorReais.ValidarChequePosicao0();
            return MostrarCheque();
        }
    }
}
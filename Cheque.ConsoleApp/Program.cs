
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequeExtenso.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cheque cheque = new Cheque();

            Cheque.cheque = (string)ConversaoPorExtenso.ConversaoValorExtenso();

            Cheque.cheque = (string)ConsoleApp.VizualizarCheque.ValorEmNumeros();

            
        }

        

        

        
    }
}

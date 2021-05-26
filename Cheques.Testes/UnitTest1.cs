using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChequeExtenso.ConsoleApp;

namespace Cheques.Testes
{
    [TestClass]
    public class TestValidadorReais
    {
        [TestMethod]
        public void TestValidacao()
        {
            Cheque cheque = new Cheque();

            Cheque.cheque = (string)ConversaoPorExtenso.ConversaoValorExtenso();

            Cheque.cheque = (string)ChequeExtenso.ConsoleApp.VizualizarCheque.ValorEmNumeros();
        }
    }
}

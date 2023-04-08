using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualFuncaoSaque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____Banco Virtual - Função Saque____\r\n");

            ContaCorrente contaFulano = new ContaCorrente();

            contaFulano.titular = "Fulano";

            Console.WriteLine("O nome do titular é " + contaFulano.titular + ".");
            Console.WriteLine("O saldo da conta era de R$ " + contaFulano.saldo + ".");

            bool resultadoSaque = contaFulano.Sacar(20);
            Console.WriteLine("O saldo atual após o saque é de R$ " + contaFulano.saldo + ".");
            Console.WriteLine("O saldo é maior que o valor sacado: " + resultadoSaque + ".");

            Console.ReadLine();
        }
    }
}

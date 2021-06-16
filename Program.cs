using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto: ");
            string valorDigitado1 = Console.ReadLine();
            if (valorDigitado1 == string.Empty)
            {
                Environment.Exit(0);
            }
            int valorProduto = Convert.ToInt32(valorDigitado1);

            Console.WriteLine("Digite o valor do pagamento: ");
            string valorDigitado2 = Console.ReadLine();
            int valorPagamento = Convert.ToInt32(valorDigitado2);

            if (valorProduto < valorPagamento)
            {
                int troco = valorPagamento - valorProduto;
                Console.WriteLine("O seu troco é de:R$ " + troco);
            }

            else
            {
                Console.WriteLine("Não tem troco bello!");
            }
        }
    }
}

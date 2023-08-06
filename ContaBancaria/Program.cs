using System.Globalization;

namespace ContaBancaria

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.WriteLine("Entre com os dados da conta");
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            

            Console.Write("Havera deposito incial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite o Saldo inicial: ");
                Console.Write("$");
                double depositoinicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
               
                conta = new Conta(numero, nome, depositoinicial);
                Console.WriteLine("Dados de deposito: "+ conta);
                
            }

            else
            {
                conta = new Conta(numero, nome);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Dados da conta:{conta} ");
                Console.WriteLine(@"──▄▀▀▀▄───────────────
──█───█───────────────
─███████─────────▄▀▀▄─
░██─▀─██░░█▀█▀▀▀▀█░░█░
░███▄███░░▀░▀░░░░░▀▀░░
");
                

            }

            Console.Write("Entre com um valor para deposito: ");
            double saldo = double.Parse(Console.ReadLine());
            conta.AumentarSaldo(saldo);
            Console.WriteLine($"Dados da conta Atlualizados: {conta} ");
            // havera deposito incial?

            Console.Write("Entre com o valor para saque: ");
            saldo = double.Parse(Console.ReadLine());
            conta.SacarDinheiro(saldo);
            Console.WriteLine($"Dados da conta atualizado: {conta}");


        }
    }
}
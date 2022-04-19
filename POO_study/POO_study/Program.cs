using System;

namespace POO_study
{
    class Program
    {
        static void Main (String[]args)
        {
            Console.WriteLine("Aprendendo OOP");

            //Criando Instancia da conta
            Conta conta = new Conta(123);
            conta.Limite = 500;

           
            //Limite da Conta
            conta.AdicionarLimite(1500);

            //Depositando
            conta.Deposita(1500);
            conta.Deposita(2500);
            conta.Deposita(3500);

            //Sacando valor
           bool saca =  conta.Saca(2000);
            if (saca)
            {
                double saldo = conta.Retorna_Saldo_Disponivel();
                Console.WriteLine($"Numero da conta:{conta.Numero   }");
                Console.WriteLine($"Seu saldo é R${saldo},00");
                Console.WriteLine($"Seu saldo é R${conta.Limite},00");
            }
         
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_study
{
    public class Conta
    {
        public Conta(int numero, double saldo) {
            this.Numero = numero;
            this.Limite = Limite; 
            Conta.ContasCriadas ++;
        }

        public Conta(int numero)
        {
           this.Numero = numero;
        }
        private double Saldo { get;  set; }
        public double Limite { get; set; }
        public int Numero { get; private set; }
        public static int ContasCriadas { get; set; }

        //metodos//
        public static int ProximaContaCriada() { 
        
            return Conta.ContasCriadas +1;
        }
        public void Deposita(double valor) { 
            this.Saldo  += valor;
        }

        public bool Saca(int valor) {

            double saldoDisponivel = Retorna_Saldo_Disponivel();
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saque indisponivel, valor exede o limite disponivel");
                return false;
            }
           
            this.Saldo -=valor;
            return true;
        }

        public void AdicionarLimite(double valor) {
            this.Limite = valor;
        }  

        public double Retorna_Saldo_Disponivel() { 
        

            return this.Saldo + this.Limite;
        }
    }
}

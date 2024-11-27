using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Modelo
{
    public class Calculadora
    {
        // // Atributos
        // public double operacao{get;set;}
        // public double valor1{get;set;}
        // public double valor2{get;set;}
        // public double result{get;set;}
        
        // // Construtor
        // public Calculadora(double operacao, double valor1, double valor2) 
        // { 
        //     this.operacao = operacao; 
        //     this.valor1 = valor1; 
        //     this.valor2 = valor2; 
        // }

        // Métodos Andar e Falar
        public double Somar(double valor1, double valor2 )
        {
            // result = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
            // Console.WriteLine($"A soma do valor: Acelerando {result} .");
            return valor1 + valor2;

        }
        public double Subtrair(double valor1, double valor2 )
        {   
            // result = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
            // Console.WriteLine($"A soma do valor: Acelerando {result} .");

            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2 )
        {   
            // result = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
            // Console.WriteLine($"A soma do valor: Acelerando {result} .");
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2 )
        {   
            // result = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
            // Console.WriteLine($"A soma do valor: Acelerando {result} .");
            if (valor2 == 0)
            {
                Console.WriteLine("Operacao de divisao nao permitido por 0");
                return double.NaN;
            }
            return valor1 / valor2 ;
        }
    }
}
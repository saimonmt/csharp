using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_csharp.Modelo
{
    public class Carro:Veiculo
    {
        // Atributos
        private bool automatico{get;set;}
        private bool numeroDePortas{get;set;}
        
        // Construtor
        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, bool numeroDePortas) : base (marca, modelo, ano, velocidadeAtual) 
        { 
            this.automatico = automatico; 
            this.numeroDePortas = numeroDePortas; 
 
        }
        // AbrirPortas e um metodo especifico da classe Carro. 
        public void AbrirPortas()
        {   
 
            Console.WriteLine($"As portas do carro estao abertas.");
        }
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//C# Extensions
//v1.7.3
//JosKreativ

using System;

using poo_csharp.Modelo;

Console.WriteLine("Criando uma instancia de Veiculo");
// Criando um objeto a partir da classe Veiculo
Veiculo obj = new Veiculo("Fiat", "Argo", 2020,10);
obj.Acelerar(83.3);
obj.Freiar(33.3);

Console.WriteLine("\nCriando uma instancia de Moto");
Moto objMoto = new Moto("Honda", "Pop", 2024, 20 , true, true );
objMoto.Acelerar(80);
objMoto.Freiar(6);
objMoto.Empinar();


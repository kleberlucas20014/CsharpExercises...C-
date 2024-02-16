using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando Construtor (usando this)");

        public class Carro
        {  
           public string? Modelo;
           public string? Montadora;
           public string? Marca;
           public int Ano;
           public int Potencia;

          public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia); 
          { 
            this.Modelo = Modelo;
            this.Montadora = Montadora;
            this.Marca = Marca;
            this.Ano = Ano;
            this.Potencia = Potencia;

          }

           public void Acelerar(string marca);
           {
              Console.WriteLine("\n Acelerando o meu " + marca);
           }



    Console.WriteLine("criando objetos usando o construtor, exibir atributos e invocar o metodo");


    Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

   chevrolet.Acelerar(chevrolet.Marca);

   Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca} {chevrolet.Ano} {chevrolet.Potencia}");

   Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

    ford.Acelerar(ford.Marca);
 
   Console.WriteLine($"{chevrolet.Modelo}{chevrolet.Montadora}{chevrolet.Marca}{chevrolet.Ano}{chevrolet.Potencia} CV");

   Console.ReadKey();
      
 
        } 



    }


}
    
   

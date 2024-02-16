using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1


{
       
     Console.WriteLine("### Classes e Objetos ###");


    public class Carro
    {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        public int Ano;
        public int Potencia;

        public void Acelerar();
        { 
           Console.WriteLine("\nAcelerando...");
        }
    }


Carro Chevrolet = new Carro();
Chevrolet.Modelo = "Sedan";
Chevrolet.Montadora = "Chevrolet";
Chevrolet.Marca = "Onix";
Chevrolet.Ano = 2016;
Chevrolet.Potencia = 110;

Chevrolet.Acelerar();
Console.WriteLine($"{Chevrolet.Modelo} {Chevrolet.Montadora} {Chevrolet.Marca} {Chevrolet.Marca} {Chevrolet.Ano} {Chevrolet.Potencia}");



Carro ford = new();
ford.Modelo = "SUV";
ford.Montadora = "Ford";
ford.Marca = "Ecosport";
ford.Ano = 2018;
ford.Potencia = 120;

Chevrolet.Acelerar();

Console.WriteLine($"`{Chevrolet.Modelo}{Chevrolet.Montadora}{Chevrolet.Marca}{Chevrolet.Ano}{Chevrolet.Potencia}");

Console.ReadKey();

Console.WriteLine("\n################################################################################");


}
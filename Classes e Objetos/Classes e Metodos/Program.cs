
using System.IO.Pipes;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("### Classes e Metodos ###");


public Carro (string? modelo, string? montadora)
{
    Modelo = modelo;
    Montadora = montadora;
        
}

Carro ford2 = new("SUV", "Ford");

Marca = null;
Ano = 0;
Potencial = 0;

public double VelocidadeMaxima(int potencia)
{
    return potencia * 1.75;
}

Console.WriteLine("Descriçao do exercicio")

/*Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não 
use a palavra-chave this)
- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro

    Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que 
vai retornar um double representando a velocidade máxima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)
*/

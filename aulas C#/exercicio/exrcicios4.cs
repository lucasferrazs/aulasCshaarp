/*

Criando uma classe "Carro": Crie uma classe chamada "Carro" com três propriedades: marca, 
modelo e ano. Em seguida, crie um objeto dessa classe e atribua valores a essas propriedades. 
Imprima esses valores na tela.

Métodos na classe "Carro": Adicione um método à classe "Carro" chamado ligarMotor, que imprime 
"O motor está ligado" na tela. Crie um objeto da classe "Carro" e chame esse método.

*/

// Resposta

using System;


public class Carro
{
 
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Carro(string marca,string modelo,int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

   
    public void ExibirInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano:{Ano}");
    }
    
    public void LigarCarro()
    {
        Console.WriteLine($"Carro esta ligado");
    }
}

public class Program
{

    public static void Main()
    {
        
        Carro carro1 = new Carro("Ford","KA", 2009);
        
        carro1.ExibirInfo();
        
        carro1.LigarCarro();
    }
}
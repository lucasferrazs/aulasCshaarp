// Arquivo: Pessoa.cs
using System;

// Definição da classe Pessoa que será usada como modelo para criar objetos
public class Pessoa
{
    // Propriedades da classe Pessoa
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe Pessoa, responsável por inicializar o objeto
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir informações da pessoa
    public void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

// Classe principal do programa
public class Program
{
    // Método principal onde a execução do programa começa
    public static void Main()
    {
        // Criação do objeto "pessoa1" utilizando a classe Pessoa
        Pessoa pessoa1 = new Pessoa("Maria", 30);
        Pessoa pessoa2 = new Pessoa("Lucas", 18);
        Pessoa pessoa3 = new Pessoa("Pedro", 23);
        Pessoa pessoa4 = new Pessoa("Miguel", 25);
        Pessoa pessoa5 = new Pessoa("Gabriel", 17);
        Pessoa pessoa6 = new Pessoa("Ana", 15);

        // Utilizando o método "ExibirInfo()" do objeto "pessoa1"
        pessoa1.ExibirInfo();
    }
}

/*

Neste exemplo, criamos uma classe chamada Pessoa, que possui duas propriedades: Nome e Idade.
A classe também possui um construtor, 
que é chamado quando um novo objeto é criado, 
e um método chamado ExibirInfo(), que exibe as informações da pessoa.

No método Main(), criamos um objeto chamado pessoa1 usando a classe Pessoa. 
Em seguida, chamamos o método ExibirInfo() do objeto pessoa1 para exibir suas informações.
*/
using System;

public class Animal
{
    // Membro público: pode ser acessado de qualquer lugar
    public string Nome;

    // Membro privado: só pode ser acessado dentro da classe Animal
    private int _idade;

    // Membro protegido: pode ser acessado dentro da classe Animal e suas classes derivadas
    protected string Especie;

    // Membro interno: pode ser acessado apenas dentro do assembly atual
    internal bool Domesticado;

    // Construtor
    public Animal(string nome, int idade, string especie, bool domesticado)
    {
        Nome = nome;
        _idade = idade;
        Especie = especie;
        Domesticado = domesticado;
    }

    // Método público: pode ser chamado de qualquer lugar
    public void Falar()
    {
        Console.WriteLine("Eu sou um " + Especie + " chamado " + Nome + ".");
    }

    // Método privado: só pode ser chamado dentro da classe Animal
    private void Aniversario()
    {
        _idade++;
    }

    // Método protegido: pode ser chamado dentro da classe Animal e suas classes derivadas
    protected string GetEspecie()
    {
        return Especie;
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade, bool domesticado)
        : base(nome, idade, "cachorro", domesticado)
    {
    }

    public void Latir()
    {
        Console.WriteLine("Au au!");
    }

    // Acessando um membro protegido a partir de uma classe derivada
    public string ObterEspecie()
    {
        return GetEspecie();
    }
}

public class Program
{
    public static void Main()
    {
        Animal animal = new Animal("Bichano", 5, "gato", true);
        animal.Falar(); // Acessando um membro público

        // Não é possível acessar membros privados fora da classe
        // animal._idade = 6; // Erro de compilação

        Cachorro cachorro = new Cachorro("Rex", 3, true);
        cachorro.Latir(); // Acessando um membro público

        // Acessando um membro interno: pode ser acessado dentro do mesmo assembly
        Console.WriteLine("O cachorro é domesticado? " + cachorro.Domesticado);
    }
}

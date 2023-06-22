/*
Em C#, construtores são métodos especiais que são chamados 
quando um objeto é criado, e destrutores são métodos chamados 
quando o objeto é destruído pelo coletor de lixo (garbage collector). 
Aqui está um exemplo simples de uma classe Carro que usa construtores e destrutores:
*/
// Arquivo: Carro.cs
using System;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Construtor padrão
    public Carro()
    {
        Console.WriteLine("Construtor padrão chamado.");
    }

    // Construtor com parâmetros
    public Carro(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Console.WriteLine($"Construtor com parâmetros" 
        + "chamado. Marca: {Marca}, Modelo: {Modelo}");
    }

    // Destrutor
    ~Carro()
    {
        Console.WriteLine("Destrutor chamado.");
    }
}

public class Program
{
    public static void Main()
    {
        // Criação de um objeto "carro1" usando o construtor padrão
        Carro carro1 = new Carro();

        // Criação de um objeto "carro2" usando o construtor com parâmetros
        Carro carro2 = new Carro("Toyota", "Corolla");

        // Os destrutores são chamados automaticamente pelo coletor de lixo 
        //(garbage collector)
        // Não é possível chamar destrutores manualmente
    }
}

/*

Neste exemplo, a classe Carro possui dois construtores e um destrutor. 
O primeiro construtor é o construtor padrão, que não recebe parâmetros 
e apenas imprime uma mensagem. O segundo construtor recebe dois 
parâmetros, marca e modelo, e atribui esses valores às propriedades 
Marca e Modelo. Além disso, ele imprime uma mensagem contendo as 
informações do carro.

O destrutor é definido usando o caractere ~ seguido pelo nome 
da classe e não possui parâmetros. No exemplo, o 
destrutor apenas imprime uma mensagem. Vale ressaltar que, 
em C#, destrutores são chamados automaticamente pelo coletor de lixo, 
e não é possível chamá-los manualmente. 
Os destrutores são usados principalmente para liberar recursos não gerenciados, 
como arquivos abertos ou conexões de rede. 
No entanto, em muitos casos, é mais comum usar o padrão IDisposable e o 
bloco using para gerenciar recursos não gerenciados em C#.


*/


/*
exercício 1: Criar uma Classe Estudante

Crie uma classe Estudante com três propriedades: Nome, Idade e Curso. 
Adicione um método construtor que permita que essas propriedades sejam 
inicializadas no momento da criação do objeto. Adicione também um método 
chamado Estudar que imprime uma mensagem na tela dizendo que o estudante 
está estudando.

exercicio 2:
Exercício 2: Criar uma Classe Livro

Crie uma classe Livro com quatro propriedades: Titulo, Autor, 
AnoPublicacao e Genero. Adicione um método construtor que 
permita que essas propriedades sejam inicializadas no momento 
da criação do objeto. Adicione também um método chamado Ler que 
imprime uma mensagem na tela dizendo que você está lendo o livro.
*/
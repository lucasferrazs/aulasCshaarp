/*Atributos estáticos e métodos estáticos são membros de uma classe 
que não estão associados a um objeto específico dessa classe. 
Eles pertencem à classe em si e são compartilhados entre todas as instâncias 
da classe. Isso significa que você pode acessá-los diretamente através 
do nome da classe,sem criar um objeto.
*/

// Arquivo: Contador.cs
using System;

public class Contador
{
    // Atributo estático que será compartilhado entre todas as 
    // instâncias da classe Contador
    public static int TotalContadores { get; private set; }

    // Propriedade não estática (associada a cada objeto)
    public int Valor { get; private set; }

    // Construtor da classe Contador
    public Contador()
    {
    // Incrementa o atributo estático TotalContadores sempre 
    //que uma nova instância é criada
        TotalContadores++;
        Valor = 0;
    }

    // Método estático que retorna o total de contadores criados
    public static int ObterTotalContadores()
    {
        return TotalContadores;
    }

    // Método não estático para incrementar o valor do contador
    public void Incrementar()
    {
        Valor++;
    }
}

public class Program
{
    public static void Main()
    {
        // Acessando o atributo estático TotalContadores 
        //diretamente através do nome da classe
        Console.WriteLine($"Total de contadores: {Contador.TotalContadores}");

        // Criando instâncias da classe Contador
        Contador contador1 = new Contador();
        Contador contador2 = new Contador();

        // Acessando o método estático ObterTotalContadores 
        // através do nome da classe
        Console.WriteLine($"Total de contadores: {Contador.ObterTotalContadores()}");

        // Usando um método não estático para incrementar o valor de cada contador
        contador1.Incrementar();
        contador2.Incrementar();
        contador2.Incrementar();

        // Exibindo o valor de cada contador (não estático)
        Console.WriteLine($"Valor do contador1: {contador1.Valor}");
        Console.WriteLine($"Valor do contador2: {contador2.Valor}");
    }
}

/*

Neste exemplo, a classe Contador possui um atributo estático chamado TotalContadores, 
que conta quantas instâncias da classe foram criadas. Além disso, 
a classe possui um método estático chamado ObterTotalContadores() 
que retorna o valor do atributo TotalContadores.
 
No método Main(), acessamos o atributo estático e o método estático 
diretamente através do nome da classe Contador, sem criar um objeto.

Também incluímos uma propriedade não estática chamada Valor e um método não estático chamado 
Incrementar(), 
que servem como exemplo para mostrar a diferença entre membros estáticos e não estáticos.

*/
/*
A herança é um recurso da programação orientada a objetos que permite 
que uma classe adquira as propriedades e métodos de outra. A herança 
pode ser de dois tipos: simples e múltipla.

Herança Simples: Na herança simples, uma classe pode herdar apenas 
uma única classe. Isso significa que uma classe derivada (classe filha) 
pode ter apenas uma única classe base (classe pai). A herança simples 
promove a reutilização do código e a hierarquia de classes.
*/

// Classe base
public class Animal
{
    public void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }
}

// Classe derivada
public class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine("O gato está miando.");
    }
}
/*
Herança Múltipla: Na herança múltipla, uma classe pode herdar de várias classes. 
Ou seja, uma classe derivada pode ter várias classes base. Embora a herança
múltipla possa parecer útil à primeira vista, ela também pode levar a uma grande 
quantidade de confusão quando duas classes base têm propriedades 
ou métodos com o mesmo nome.

Em C#, a herança múltipla de classes não é suportada devido à 
ambiguidade que ela pode causar. No entanto, C# suporta herança
múltipla de interfaces. Uma classe pode implementar várias 
interfaces, o que pode ser visto como uma forma de herança múltipla.
*/

public interface ICaminhante
{
    void Caminhar();
}

public interface ICacador
{
    void Cacar();
}

public class Gato : ICaminhante, ICacador
{
    public void Caminhar()
    {
        Console.WriteLine("O gato está caminhando.");
    }

    public void Cacar()
    {
        Console.WriteLine("O gato está caçando.");
    }
}

/*

Crie duas interfaces, ILeitor e IEscritor, cada uma com um método, Ler e Escrever 
respectivamente. Crie uma classe Usuario que implementa ambas as interfaces. 
O método Ler deve imprimir "Lendo..." e o método Escrever deve imprimir 
"Escrevendo...". Crie um objeto da classe Usuario e chame ambos os métodos.

Crie duas interfaces, IVoador e ICorredor, cada uma com um método, 
Voar e Correr respectivamente. Crie uma classe SuperHeroi que implementa 
ambas as interfaces. O método Voar deve imprimir "Voando alto no céu..." 
e o método Correr deve imprimir "Correndo muito rápido...". Crie um 
objeto da classe SuperHeroi e chame ambos os métodos.

Crie três interfaces, ITocadorGuitarra, ITocadorBaixo e ITocadorBateria, 
cada uma com um método, TocarGuitarra, TocarBaixo e TocarBateria respectivamente. 
Crie uma classe Musico que implemente as três interfaces. Cada método deve imprimir 
uma mensagem apropriada, como "Tocando guitarra...", "Tocando baixo..." e 
"Tocando bateria...". Crie um objeto da classe Musico e chame todos os três métodos.
*/
/*
A palavra-chave base em C# é usada para acessar membros 
(métodos, propriedades, etc.) na classe base a partir 
de uma classe derivada.

Considere a seguinte situação onde você tem uma classe 
base Animal e uma classe derivada Gato:
*/

public class Animal
{
    public virtual void Comer()
    {
        Console.WriteLine("O animal está comendo.");
    }
}

public class Gato : Animal
{
    public override void Comer()
    {
        Console.WriteLine("O gato está comendo.");
    }
    
    public void ComerComoAnimal()
    {
        base.Comer(); // Acessa o método Comer da classe base Animal
    }
}
/*
a classe Gato, usamos a palavra-chave base para chamar o método Comer 
da classe base Animal dentro do método ComerComoAnimal.

Este é um uso comum da palavra-chave base - para chamar um método 
na classe base que foi sobrescrito na classe derivada. Isso pode ser 
útil quando você quer adicionar algum comportamento adicional na 
classe derivada, mas também quer preservar o comportamento da classe base.

Note que base só pode ser usada em métodos de instância, construtores 
de instância ou acessadores de propriedade de instância.

*/
/*
As interfaces são um recurso importante na programação 
orientada a objetos (OOP) e no C#, elas desempenham um 
papel crucial. Uma interface é uma definição de um 
contrato que especifica um conjunto de métodos (e 
possivelmente propriedades, eventos ou índices) que 
uma classe ou estrutura deve implementar.

As interfaces não contêm qualquer implementação de 
métodos, apenas suas assinaturas. Uma classe que 
implementa uma interface deve fornecer a implementação
dos métodos declarados na interface.
*/

// Definição da interface
public interface IVoar
{
    void Voar();
}

// Classe Pássaro implementando a interface IVoar
public class Passaro : IVoar
{
    public void Voar()
    {
        Console.WriteLine("O pássaro está voando");
    }
}
/*Neste exemplo, a interface IVoar declara um método 
chamado Voar. A classe Pássaro implementa essa interface, 
indicando que fornecerá uma implementação do método Voar.

As interfaces em C# são extremamente úteis para garantir 
que uma classe cumpra um determinado contrato, o que é 
especialmente útil em situações onde você quer garantir 
que um grupo de classes relacionadas todas implementem 
um conjunto específico de métodos. As interfaces também 
são fundamentais para o princípio de programação orientada 
a objetos da substituição, onde um objeto de uma classe 
pode ser substituído por um objeto de outra classe, desde 
que ambas as classes implementem a mesma interface.
*/


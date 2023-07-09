/*A implementação de interfaces em C# é uma 
maneira de garantir que uma classe particular 
siga um 'contrato' específico. Esse contrato é 
definido pela interface e contém as assinaturas 
de um conjunto de métodos (e possivelmente propriedades, 
eventos ou índices) que a classe deve implementar.
*/

// Interface
public interface IFalar
{
    void Falar();
}

// Classe que implementa a interface
public class Pessoa : IFalar
{
    public void Falar()
    {
        Console.WriteLine("A pessoa está falando.");
    }
}


/*Neste exemplo, a interface IFalar tem um único método 
chamado Falar. A classe Pessoa implementa essa interface, 
o que significa que a classe Pessoa deve ter um método Falar.

Note a sintaxe usada: para implementar uma interface, 
usamos dois pontos (:) após o nome da classe e, em seguida, 
o nome da interface. Se houvesse mais de uma interface 
para implementar, elas seriam separadas por vírgulas.

A implementação do método Falar na classe Pessoa usa a 
palavra-chave public antes do nome do método. Isso é 
necessário porque os métodos de interface são publicamente 
acessíveis por padrão. Finalmente, o método Falar em Pessoa 
tem a mesma assinatura que o método Falar na interface IFalar.

Agora, qualquer objeto da classe Pessoa pode ser tratado 
como um objeto do tipo IFalar, permitindo que você chame 
o método Falar nesse objeto. Isso é útil quando você quer 
interagir com um grupo de objetos de diferentes tipos de 
maneira uniforme, desde que todos eles implementem a mesma 
interface.
*/
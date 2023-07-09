/*
Classes abstratas são um conceito chave na programação 
orientada a objetos (POO). Em C#, uma classe abstrata é 
uma classe que não pode ser instanciada, ou seja, você não 
pode criar um objeto diretamente dela. Em vez disso, 
ela serve como uma classe base que outras classes podem herdar.

As classes abstratas são frequentemente usadas quando você 
deseja fornecer alguma funcionalidade comum a várias classes, 
mas essa funcionalidade por si só não é completa ou faz sentido 
para ser instanciada.
*/
public abstract class Animal // Classe abstrata
{
    public int NumeroDePatas { get; set; }

    public abstract void FazerSom(); // Método abstrato
}
/*Neste exemplo, Animal é uma classe abstrata com uma propriedade 
NumeroDePatas e um método FazerSom. Note que o método FazerSom é 
declarado como abstract. Isso significa que ele não tem uma 
implementação na classe Animal e deve ser implementado em 
qualquer classe que herde de Animal.*/

public class Cachorro : Animal // Cachorro herda de Animal
{
    public Cachorro()
    {
        NumeroDePatas = 4;
    }

    public override void FazerSom() // Implementação do método abstrato
    {
        Console.WriteLine("Au Au");
    }
}
/*Neste exemplo, a classe Cachorro herda da classe 
Animal e fornece uma implementação para o método 
FazerSom. Também define o valor da propriedade NumeroDePatas 
no construtor. Agora você pode criar instâncias da classe 
Cachorro e cada instância terá a propriedade NumeroDePatas 
e o método FazerSom.
*/
/*
Exercício 1 - Classe Animal e suas subclasses
Crie uma classe abstrata chamada Animal com um método abstrato chamado 
FazerSom(). Em seguida, crie duas subclasses: Cachorro e Gato, que herdem
de Animal e implementem o método FazerSom(). Em cada uma das subclasses, 
o método FazerSom() deve imprimir na tela um som representativo do 
respectivo animal (por exemplo: "Au au!" para Cachorro e "Miau!" para Gato).

Exercício 2 - Classe Shape (forma) e suas subclasses
Defina uma classe abstrata chamada Shape (forma) com um 
método abstrato CalcularArea(). Crie duas subclasses, 
Circulo e Retangulo, que herdam de Shape e implementem o 
método CalcularArea(). O método CalcularArea() deve 
retornar a área da forma geométrica que a classe 
representa (use o valor 3.14 para representar pi no 
caso do círculo).

Exercício 3 - Classe Veículo e suas subclasses

Crie uma classe abstrata chamada Veiculo com dois 
métodos abstratos, Acelerar() e Frear(). Em seguida, 
crie duas subclasses que herdem de Veiculo: Carro e 
Bicicleta. Em cada uma dessas subclasses, implemente 
os métodos Acelerar() e Frear(). Esses métodos devem 
imprimir uma mensagem simples na tela, como "Acelerando 
o carro" ou "Freando a bicicleta".
*/

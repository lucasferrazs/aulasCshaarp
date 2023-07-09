/*Métodos abstratos são métodos que são declarados 
em uma classe abstrata, mas não têm uma implementação 
nesta classe. A implementação destes métodos é 
fornecida nas classes derivadas que herdam da classe 
abstrata. Em C#, métodos abstratos são criados usando 
as palavras-chave abstract e void.
*/

public abstract class Animal
{
    public abstract void FazerSom();
}

/*Neste exemplo, FazerSom é um método abstrato na 
classe abstrata Animal. Este método não tem uma 
implementação na classe Animal - ele apenas declara 
que qualquer classe que herde de Animal deve fornecer 
uma implementação para o método FazerSom.
*/
public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}
/*
Neste exemplo, a classe Cachorro herda da classe 
Animal e fornece uma implementação para o método 
FazerSom. Quando você cria uma instância da classe 
Cachorro e chama o método FazerSom, ele irá imprimir 
"Au au!" na console.
*/

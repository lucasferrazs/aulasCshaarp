/*
Polimorfismo é um dos quatro princípios fundamentais da 
programação orientada a objetos (POO), juntamente com 
encapsulamento, herança e abstração. O termo polimorfismo 
vem do grego e significa "muitas formas".

Na programação, o polimorfismo é a capacidade de um 
objeto poder ser tratado de várias formas. É uma 
maneira de permitir que uma classe herde as características 
de outra classe, mas com a capacidade de implementar 
funcionalidades específicas da classe.

Existem dois tipos de polimorfismo em C#: estático e dinâmico.

Polimorfismo Estático: Também chamado de polimorfismo em 
tempo de compilação, ocorre quando o polimorfismo é 
expresso pelo sobrecarga de métodos ou operadores.

Polimorfismo Dinâmico: Também chamado de polimorfismo 
em tempo de execução, ocorre quando o polimorfismo é 
expresso pela sobrescrita de métodos. Isso significa 
que temos um método (na classe base) que é substituído 
pela classe derivada e a chamada a esse método será 
resolvida em tempo de execução com base no tipo real 
do objeto, mesmo que o tipo da referência ao objeto 
seja o da classe base.
*/
public class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som");
    }
}

public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late");
    }
}

public class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia");
    }
}

public class TestePolimorfismo
{
    public static void Executar()
    {
        Animal meuCachorro = new Cachorro();
        Animal meuGato = new Gato();

        meuCachorro.FazerSom(); // O cachorro late
        meuGato.FazerSom(); // O gato mia
    }
}
/*
Neste exemplo, meuCachorro e meuGato são tratados como 
objetos do tipo Animal, mas cada um deles se comporta 
de acordo com o tipo de animal que realmente são 
quando o método FazerSom é chamado. Isso é um 
exemplo de polimorfismo em ação.
*/
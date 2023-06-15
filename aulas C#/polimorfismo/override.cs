/*
As palavras-chave virtual, override e new em C# são usadas 
para controlar a herança e a substituição de membros em 
classes e são importantes para a programação orientada a objetos.

virtual: A palavra-chave virtual é usada para modificar uma 
declaração de método, propriedade, indexador ou evento e 
permitir que seja substituído em uma classe derivada. Por exemplo:

*/

public class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("O animal faz um som.");
    }
}
/*
override: A palavra-chave override é usada para estender 
ou modificar o comportamento de um método, propriedade, 
indexador ou evento de uma classe base que é marcado como virtual.
*/

public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O cachorro late.");
    }
}
/*
Neste exemplo, a classe Cachorro está substituindo o método 
Falar da classe Animal para fornecer uma implementação 
específica para a classe Cachorro.


new: A palavra-chave new é usada para ocultar um membro 
herdado da classe base. É diferente de override porque 
new não requer que o membro na classe base seja marcado 
com virtual. Além disso, ao usar new, a escolha de qual 
membro chamar (o da classe base ou o da classe derivada) 
é feita em tempo de compilação, enquanto com override é 
feita em tempo de execução.

*/

public class Gato : Animal
{
    public new void Falar()
    {
        Console.WriteLine("O gato mia.");
    }
}
/*
Neste exemplo, se tivermos um objeto Gato referido 
por uma variável do tipo Animal e chamarmos o 
método Falar, será chamado o método Falar da classe 
Animal, não o da classe Gato. Isso é diferente do que 
aconteceria se tivéssemos usado override em vez de new.

Essas palavras-chave permitem que você crie hierarquias 
de classes flexíveis e extensíveis onde as classes 
derivadas podem personalizar e estender a funcionalidade 
fornecida por suas classes base.
*/

public class Animal
{
    public virtual string Som { get; set; }

    public Animal()
    {
        Som = "O animal faz um som";
    }
}

public class Cachorro : Animal
{
    public override string Som 
    { 
        get { return base.Som; }
        set { base.Som = "O cachorro late"; }
    }
}

public class Gato : Animal
{
    public override string Som 
    { 
        get { return base.Som; }
        set { base.Som = "O gato mia"; }
    }
}


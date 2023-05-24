/*
Herança é um princípio fundamental da programação orientada a objetos (OOP) 
que permite que uma classe adquira as propriedades e métodos de outra classe. 
Em C#, a herança é indicada pela palavra-chave :.

A classe que é herdada é chamada de "classe base" ou "classe pai", 
e a classe que herda é chamada de "classe derivada" ou "classe filha".
*/
public class Animal // Classe base
{
    public void Comer()
    {
        Console.WriteLine("O animal está comendo...");
    }
}

public class Gato : Animal // Classe derivada
{
    public void Miar()
    {
        Console.WriteLine("O gato está miando...");
    }
}

public class Program
{
    public static void Main()
    {
        Gato gato = new Gato();
        
        gato.Comer(); // Método herdado da classe Animal
        gato.Miar(); // Método da própria classe Gato
    }
}
/*
No exemplo acima, Gato é uma classe derivada da classe base Animal. Isso significa 
que um objeto Gato pode acessar o método Comer definido na classe Animal, 
além de seu próprio método Miar.

A herança é uma maneira eficiente de reutilizar código, pois permite que as 
classes compartilhem métodos e propriedades comuns. No entanto, em C#, uma classe 
só pode herdar diretamente de uma única classe (herança simples). Para compartilhar 
funcionalidades entre várias classes que não têm uma relação de herança comum, 
você pode usar interfaces.

É importante notar que, embora a herança seja uma ferramenta poderosa, 
ela deve ser usada com cuidado, de acordo com o princípio da substitutibilidade 
de Liskov - que é, em termos simples, um objeto de uma classe derivada deve ser 
capaz de substituir um objeto de sua classe base sem alterar a correção do programa.
*/
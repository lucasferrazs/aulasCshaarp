/*
Os modificadores de acesso em C# definem a visibilidade dos 
membros (métodos, propriedades, campos etc.) de uma classe 
ou estrutura. Os diferentes modificadores de acesso em C# são:

public: O membro pode ser acessado de qualquer lugar. 
Não há restrição de acesso.

private: O membro pode ser acessado apenas pela própria 
classe. É o nível de acesso mais restritivo.

protected: O membro pode ser acessado apenas pela classe 
que o declara e por qualquer classe que a derive.

internal: O membro pode ser acessado apenas dentro do 
mesmo assembly. Um assembly é geralmente o arquivo 
.exe ou .dll onde o código é compilado.

protected internal: É uma combinação de protected e 
internal. O membro pode ser acessado de qualquer classe 
no mesmo assembly, bem como qualquer classe que a derive.

A palavra-chave protected é particularmente útil ao 
lidar com herança. Membros marcados como protected 
podem ser acessados na classe base e em qualquer 
classe que herde da classe base.
*/

public class Animal
{
    protected string Nome;

    public Animal(string nome)
    {
        Nome = nome;
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome)
        : base(nome) // Chama o construtor da classe base
    {
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, eu sou um cachorro e meu nome é {Nome}");
    }
}

/*
Neste exemplo, Nome é um campo protected na classe Animal. 
Isso significa que podemos acessá-lo diretamente na classe 
Cachorro, que é derivada de Animal.
*/
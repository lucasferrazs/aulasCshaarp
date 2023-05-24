public class Pessoa
{
    // Propriedade com acessadores get e set para o nome
    // O código externo pode obter e atribuir valores a essa propriedade
    public string Nome { get; set; }

    // Campo privado para armazenar a idade
    private int _idade;

    // Propriedade com acessadores get e set personalizados para a idade
    public int Idade
    {
        // Acessador get: permite obter o valor do campo _idade
        get
        {
            return _idade;
        }
        // Acessador set: permite atribuir um valor ao campo _idade com validação
        set
        {
            if (value >= 0)
            {
                _idade = value;
            }
            else
            {
                _idade = 0;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();

        // Atribuindo valores usando as propriedades
        pessoa.Nome = "Maria";
        pessoa.Idade = 30;

        // Obtendo valores usando as propriedades
        string nome = pessoa.Nome;
        int idade = pessoa.Idade;

        System.Console.WriteLine("Nome: " + nome);
        System.Console.WriteLine("Idade: " + idade);
    }
}
/*
Neste exemplo, temos uma classe Pessoa com uma propriedade pública Nome 
e um campo privado _idade. A propriedade Nome usa acessadores get e set 
automáticos, permitindo que o código externo obtenha e atribua valores 
diretamente à propriedade.

Para a idade, criamos uma propriedade Idade com acessadores 
get e set personalizados. O acessador get permite obter o valor 
do campo _idade, e o acessador set permite atribuir um valor ao 
campo _idade com validação para garantir que o valor seja válido.

No método Main, criamos uma instância da classe Pessoa 
e usamos as propriedades para atribuir valores ao Nome 
e Idade. Em seguida, usamos as propriedades para obter 
os valores e os exibimos no console.
*/
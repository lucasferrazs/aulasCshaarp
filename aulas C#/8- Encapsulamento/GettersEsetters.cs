public class Pessoa
{
    // Campo privado para armazenar o nome
    private string _nome;

    // Campo privado para armazenar a idade
    private int _idade;

    // Getter para o nome: permite obter o valor do campo _nome
    public string GetNome()
    {
        return _nome;
    }

    // Setter para o nome: permite atribuir um valor ao campo _nome com validação
    public void SetNome(string nome)
    {
        if (!string.IsNullOrEmpty(nome))
        {
            _nome = nome;
        }
        else
        {
            _nome = "Nome não informado";
        }
    }

    // Getter para a idade: permite obter o valor do campo _idade
    public int GetIdade()
    {
        return _idade;
    }

    // Setter para a idade: permite atribuir um valor ao campo _idade com validação
    public void SetIdade(int idade)
    {
        if (idade >= 0)
        {
            _idade = idade;
        }
        else
        {
            _idade = 0;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();

        // Atribuindo valores usando os setters
        pessoa.SetNome("Maria");
        pessoa.SetIdade(30);

        // Obtendo valores usando os getters
        string nome = pessoa.GetNome();
        int idade = pessoa.GetIdade();

        System.Console.WriteLine("Nome: " + nome);
        System.Console.WriteLine("Idade: " + idade);
    }
}

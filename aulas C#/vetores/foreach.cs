/*
O foreach é uma estrutura de repetição em C# usada para 
percorrer todos os elementos de uma coleção, como vetores (arrays), 
listas ou qualquer objeto que implemente a interface IEnumerable. 
Ele simplifica a iteração sobre a coleção sem a necessidade de usar um contador ou índice, 
como em um laço for.

Aqui está um exemplo de como usar o foreach em C# com comentários explicativos:
*/

// Cria e inicializa um vetor de strings.
string[] nomes = new string[] { "Ana", "João", "Maria", "Pedro" };

// A estrutura 'foreach' é usada para percorrer todos os elementos da coleção 'nomes'.
// A variável 'nome' é usada para armazenar o valor do elemento atual a cada iteração do laço.
// O tipo da variável 'nome' deve ser compatível com o tipo de elemento da coleção.
 foreach (string nome in nomes)
{
    // Neste bloco de código, você pode acessar o valor do elemento atual por meio da variável 'nome'.
    // Imprime o valor do elemento atual no console.
    Console.WriteLine("Nome: " + nome);
}

// Cria e inicializa um vetor de inteiros.
int[] numeros = new int[] { 1, 2, 3, 4, 5 };

// Usa 'foreach' para percorrer todos os elementos do vetor 'numeros'.
 foreach (int numero in numeros)
{
    // Imprime o valor do elemento atual no console.
    Console.WriteLine("Número: " + numero);
}

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

/*
Vetores (também chamados de arrays) em C# são estruturas de dados que
armazenam uma coleção de 
elementos do mesmo tipo, acessados por meio de índices.
Um vetor tem um tamanho fixo, 
que é definido no momento da criação.
Aqui está um exemplo de como criar, preencher e acessar 
elementos de um vetor em C#:
*/

// Cria um vetor de inteiros com tamanho 5.
// Os índices do vetor variam de 0 a 4 (tamanho - 1).
int[] numeros = new int[5];

// Preenche o vetor com valores.
// Os índices são usados para acessar e atribuir valores aos elementos do vetor.
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Imprime o valor do elemento no índice 2 do vetor.
Console.WriteLine("O valor no índice 2 é: " + numeros[2]);

//soma entre arrays
int resultado = numeros[0] + numeros[1]
Console.WriteLine(resultado)

// Você também pode criar e inicializar um vetor diretamente com valores específicos.
string[] nomes = new string[] { "Ana", "João", "Maria", "Pedro" };

// Imprime o valor do elemento no índice 1 do vetor 'nomes'.
Console.WriteLine("O nome no índice 1 é: " + nomes[1]);

// Percorre todos os elementos do vetor 'nomes' usando um laço 'for'.
for (int i = 0; i < nomes.Length; i++)
{
 // A propriedade 'Length' retorna o tamanho do vetor.
 // Imprime o valor e o índice do elemento atual no console.
 Console.WriteLine("Nome no índice " + i + ": " + nomes[i]);
}

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

/*
Encontrar o máximo e mínimo:
Escreva um programa que encontre o valor máximo e mínimo em um array de inteiros.

Calcular a média:
Escreva um programa que calcule a média dos elementos em um array de números.

Encontrar a soma:
Escreva um programa que encontre a soma de todos os elementos em um array de números.

Verificar se o array está ordenado:
Escreva um programa que verifique se um array está ordenado em ordem crescente.
*/
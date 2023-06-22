// A variável 'n' define o número de vezes que o laço será executado.
int n = 10;
int[] numeros = new int[5]; 

// A estrutura 'for' é usada para repetir um bloco de código um número específico de vezes.
// Neste exemplo, o laço será executado 10 vezes.
// O laço começa com a variável 'i' inicializada com o valor 0.
// A condição de continuação do laço é 'i < n', ou seja, 
//o laço será executado enquanto 'i' for menor que 'n'.
// A cada iteração do laço, 'i' é incrementado em 1, conforme a expressão 'i++'.
for (int i = 0; i < numeros.Length; i++)
{
    // Este bloco de código será executado a cada iteração do laço.
    // Neste caso, apenas imprimirá o valor atual de 'i' no console.
    Console.WriteLine("Número atual: " + i);
}

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

 
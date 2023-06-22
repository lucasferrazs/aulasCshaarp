// A variável 'contador' será usada para controlar o número de iterações do laço.
int contador = 0;
// A variável 'limite' define o número máximo de iterações que o laço irá executar.
int limite = 10;

// A estrutura 'while' é usada para repetir um bloco de código enquanto uma condição for verdadeira.

// A condição de continuação do laço é 'contador < limite', ou seja, 
// o laço será executado enquanto 'contador' for menor que 'limite'.

while (contador < limite)
{
// Este bloco de código será executado a cada iteração do laço.
// Neste caso, apenas imprimirá o valor atual de 'contador' no console.
Console.WriteLine("Número atual: " + contador);
// Incrementa o 'contador' em 1 a cada iteração do laço.
 contador++;
}

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
 


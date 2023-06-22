// A variável 'contador' será usada para controlar o número de iterações do laço.
int contador = 0;

// A variável 'limite' define o número máximo de iterações que o laço irá executar.
int limite = 10;

// A estrutura 'do-while' é usada para repetir um bloco de código enquanto uma condição for verdadeira.
// A diferença entre o 'do-while' e o 'while' é que o 'do-while' sempre executará o bloco de código pelo menos uma vez,
// independentemente da condição, porque a verificação da condição ocorre no final do laço.
do
{
    // Este bloco de código será executado a cada iteração do laço.
    // Neste caso, apenas imprimirá o valor atual de 'contador' no console.
    Console.WriteLine("Número atual: " + contador);

    // Incrementa o 'contador' em 1 a cada iteração do laço.
    contador++;
}
// A condição de continuação do laço é 'contador < limite', ou seja,
// o laço será executado enquanto 'contador' for menor que 'limite'.
while (contador < limite);

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
 

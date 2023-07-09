/*Na programação, uma exceção é um evento que ocorre 
durante a execução de um programa e que interrompe o 
fluxo normal de instruções. Quando um erro ocorre em 
um programa, a maioria dos sistemas de linguagem de 
programação fornece uma maneira de "lançar" uma exceção 
que pode ser "capturada" por um código especializado para 
lidar com o erro.

As exceções são usadas para indicar que ocorreu uma 
condição de erro. Em vez de usar códigos de retorno 
de erro e fazer com que o código do programa esteja 
constantemente verificando erros, as exceções fornecem 
uma maneira de desviar o fluxo de controle para uma 
rotina de tratamento de erros quando ocorre um erro.

Em C#, as exceções são representadas por instâncias 
de classes de exceção. A classe base para todas as 
exceções em C# é a classe System.Exception. Essa 
classe fornece várias propriedades e métodos que 
são comuns a todas as exceções.
*/
try
{
    int x = 0;
    int y = 5;
    int z = y / x; // Isso vai causar uma exceção (divisão por zero)
}
catch (Exception ex)
{
    Console.WriteLine("Uma exceção foi capturada: " + ex.Message);
}
/*No bloco try, nós tentamos executar algum código que 
pode lançar uma exceção. Se ocorrer uma exceção, o fluxo 
de controle é imediatamente transferido para o bloco catch 
mais próximo que pode lidar com essa exceção. No bloco catch, 
lidamos com a exceção. Neste caso, estamos apenas imprimindo 
a mensagem de exceção para a saída padrão.
*/

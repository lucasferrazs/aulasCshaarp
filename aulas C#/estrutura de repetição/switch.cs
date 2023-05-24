
// Solicita ao usuário que insira um número de 1 a 3.
Console.Write("Digite um número entre 1 e 3: ");
int numero = int.Parse(Console.ReadLine());

// A estrutura 'switch' é usada para selecionar um bloco de
// código a ser executado com base no valor de uma variável ou expressão.
// Neste exemplo, a estrutura 'switch' é usada 
//para verificar o valor da variável 'numero'.
switch (numero)
{
    // O 'case' é usado para definir uma condição específica que,
    // se atendida, executará o bloco de código associado a ela.
    // Neste caso, se 'numero' for igual a 1, o bloco de código a seguir será executado.
    case 1:
    Console.WriteLine("Você digitou o número 1.");
    // A instrução 'break' é usada para sair do bloco 'switch' após a execução do 
    // bloco de código correspondente.
    break;

    // Se 'numero' for igual a 2, o bloco de código a seguir será executado.
    case 2:
    Console.WriteLine("Você digitou o número 2.");
    break;

    // Se 'numero' for igual a 3, o bloco de código a seguir será executado.
    case 3:
    Console.WriteLine("Você digitou o número 3.");
    break;

    // O 'default' é usado para executar um bloco de código quando nenhuma das 
    //condições 'case' é atendida.
    // Neste caso, se 'numero' não for igual a 1, 2 ou 3, o bloco de código 
    //a seguir será executado.
    default:
    Console.WriteLine("Número inválido. Digite um número entre 1 e 3.");
    break;
            }

// Aguarda o usuário pressionar uma tecla para encerrar o programa.
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
   
   /*
   
   Exercício de dias da semana: Crie um programa que lê um número de 1 a 7 
   e imprime o dia da semana correspondente. Use um comando switch para 
   selecionar o dia da semana com base no número digitado. Por exemplo, 
   se o usuário digitar 1, o programa deve imprimir "Domingo". Se o usuário 
   digitar 7, o programa deve imprimir "Sábado".

    Exercício de operações matemáticas: Crie um programa que lê dois números 
    e um operador (como '+', '-', '*' ou '/'). Em seguida, use um comando 
    switch para realizar a operação matemática correspondente. 
    Por exemplo, se os números forem 3 e 4, e o operador for '+', 
    o programa deve imprimir 7.

    Exercício de cores: Crie um programa que lê o nome de uma cor em inglês 
    (como "red", "green" ou "blue") e, em seguida, use um comando switch
    para imprimir uma frase que descreve a cor. Por exemplo, se o usuário 
    digitar "red", o programa pode imprimir "Red is the color of apples 
    and roses."
   */
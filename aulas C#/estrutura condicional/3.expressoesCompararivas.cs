/*
As estruturas comparativas são um recurso fundamental da linguagem de programação 
C# que permitem comparar valores de variáveis e tomar decisões com base nesses valores.
As estruturas comparativas são usadas em conjunto com as estruturas de controle de fluxo,
como as estruturas condicionais e de repetição, para criar programas que tomam decisões
de forma automatizada.

As estruturas comparativas em C# incluem os operadores de comparação, que são usados 
para comparar valores de variáveis. Os operadores de 
comparação em C# incluem os seguintes:

Igual a (==)
Diferente de (!=)
Maior que (>)
Maior ou igual a (>=)
Menor que (<)
Menor ou igual a (<=)

Um exemplo simples de estrutura comparativa em C# é uma estrutura 
condicional que verifica se um número
é positivo ou negativo. O código abaixo demonstra como isso pode 
ser feito utilizando o operador de 
comparação maior que (>):
*/

int numero = -5;

if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}
else
{
    Console.WriteLine("O número é negativo.");
}

/*
Nesse exemplo, a expressão numero > 0 compara o valor da variável numero com o valor 0 
utilizando o operador maior que (>). Se numero for maior que 0, o código dentro do bloco 
if é executado, imprimindo a mensagem "O número é positivo.". Se numero não for maior que 0, 
o código dentro do bloco else é executado, imprimindo a mensagem "O número é negativo.".

Outro exemplo de estrutura comparativa em C# é uma estrutura condicional que verifica 
se um 
número é divisível por 2. O código abaixo demonstra como isso pode ser feito utilizando 
o operador de comparação igual a (==):
*/
int numero = 6;

if (numero % 2 == 0)
{
    Console.WriteLine("O número é divisível por 2.");
}
else
{
    Console.WriteLine("O número não é divisível por 2.");
}
/*
Nesse exemplo, a expressão numero % 2 == 0 compara o resto da divisão da variável
numero por 2 com o valor 0 utilizando o operador igual a (==). Se o resto da 
divisão for igual a 0,o código dentro do bloco if é executado, imprimindo a 
mensagem "O número é divisível por 2.".Se o resto da divisão não for igual a 0, 
o código dentro do bloco else é executado, imprimindo a mensagem "O número não é 
divisível por 2.".

Em resumo, as estruturas comparativas em C# são usadas para comparar valores de 
variáveis e tomar decisões com base nesses valores. Essas estruturas são 
fundamentais para a criação de programas que tomam decisões de forma 
automatizada e são utilizadas em conjunto com as estruturas de controle 
de fluxo para criar programas complexos e eficientes.
*/
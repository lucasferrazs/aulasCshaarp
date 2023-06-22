/*
As expressões lógicas são utilizadas na programação 
para representar relações de verdade ou 
falsidade entre variáveis, operando com valores booleanos 
(verdadeiro ou falso). Essas expressões 
são fundamentais para a criação de estruturas condicionais e 
de controle de fluxo em um programa.

Entre as operações lógicas mais comuns em programação estão as operações E (&&) 
e OU (||). A operação E retorna verdadeiro somente se ambas as expressões comparadas 
forem verdadeiras. Já a operação OU retorna verdadeiro se ao menos uma das expressões 
comparadas for verdadeira.

Abaixo segue uma tabela verdade para as operações lógicas E e OU:

| Expressão 1 | Expressão 2 | E (&&) | OU (||) |
|-------------|-------------|--------|---------|
| Falso |         Falso |      Falso | Falso |
| Falso | Verdadeiro|          Falso | Verdadeiro|
| Verdadeiro| Falso |          Falso | Verdadeiro|
| Verdadeiro| Verdadeiro|    Verdadeiro|Verdadeiro|

*/
//Exemplo de && em C#

int x = 5;
int y = 10;

if (x > 0 && y > 0)
{
    Console.WriteLine("x e y são positivos.");
}
else
{
    Console.WriteLine("x e/ou y são negativos.");
}
/*
Nesse exemplo, a expressão x > 0 && y > 0 representa a operação E entre as expressões 
x > 0 e y > 0. O código dentro do bloco if é executado somente se ambas as expressões 
forem verdadeiras, ou seja, se tanto x quanto y forem maiores que zero.
*/

//Exemplo de uso da operação OU em C#:

int a = 5;
int b = -2;

if (a > 0 || b > 0)
{
    Console.WriteLine("Pelo menos uma das variáveis é positiva.");
}
else
{
    Console.WriteLine("Ambas as variáveis são negativas.");
}
/*
Nesse exemplo, a expressão a > 0 || b > 0 representa a operação OU entre as expressões 
a > 0 e b > 0. O código dentro do bloco if é executado se ao menos uma das expressões 
for verdadeira, ou seja, se a for maior que zero ou b for maior que zero.

Em resumo, as operações lógicas E e OU são utilizadas para combinar expressões 
lógicas e testar a verdade ou falsidade dessas expressões de forma conjunta. 
Essas operações são fundamentais para a criação de condições e estruturas de 
controle de fluxo em um programa.
*/


/*Tabuada:
Peça ao usuário para inserir um número inteiro e exiba a tabuada desse número de 1 a 10.

Soma dos N primeiros números:
Peça ao usuário para inserir um número inteiro N e calcule a 
soma dos N primeiros números inteiros (1 + 2 + 3 + ... + N).

Contagem regressiva:
Peça ao usuário para inserir um número inteiro e exiba uma 
contagem regressiva a partir desse número até 0.
*/







/*

Divisão por dois: Escreva um programa que pede ao usuário para inserir um número e,
em seguida, continue dividindo o número por 2 até que o resultado seja menor que 1. 
Imprima cada passo na tela.

Número de dígitos: Escreva um programa que pede ao usuário para inserir um número e, 
em seguida, calcule e imprima na tela o número de dígitos nesse número. Para isso, 
você pode dividir o número por 10 repetidamente até que ele seja 0 e contar quantas
vezes você fez a divisão.

Impressão dos números pares: Escreva um programa que pede ao usuário para inserir 
um número e exiba na tela todos os números pares de 0 até o número inserido





*/


class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        while (num != 0)
        {
            num /= 10;
            contador++;
        }

        Console.WriteLine("O número de dígitos é: " + contador);
    }
}
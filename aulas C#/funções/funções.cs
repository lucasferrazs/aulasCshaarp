/*
Uma função em C# é um bloco de código que executa uma 
tarefa específica e pode ser reutilizado em diferentes 
partes do programa. Para criar uma função em C#, 
você precisa definir o nome da função, seus parâmetros 
(se houver) e o tipo de retorno (se houver).
*/

[modificador de acesso] [tipo de retorno] NomeDaFuncao([lista de parametros]) 
{
    // corpo da função
    return [valor de retorno];
}

/*
aqui está um exemplo de uma função 
simples que recebe dois números inteiros 
como parâmetros e retorna a soma:
*/
public int Soma(int a, int b) {
    int resultado = a + b;
    return resultado;
}
/*
Neste exemplo, a função é chamada "Soma" e tem dois 
parâmetros do tipo inteiro chamados "a" e "b".
Dentro do corpo da função, os dois parâmetros são somados e o 
resultado é armazenado em uma variável chamada "resultado".
Em seguida, o valor de "resultado" é retornado 
como o valor de retorno da função.
*/


public bool VerificaParidade(int numero) {
    if (numero % 2 == 0) {
        return true;
    } else {
        return false;
    }
}
/*
Neste exemplo, a função é chamada "VerificaParidade" 
e tem um parâmetro do tipo inteiro chamado "numero". 
Dentro do corpo da função, é verificado se o número é 
par ou ímpar usando o operador módulo (%). 
Se o número for par, a função retorna verdadeiro, caso contrário, retorna falso.
*/


/*
Para fazer uma chamada de função devemos criar uma variavel para armazanar
o valor da função.
Por exemplo, considere a seguinte função em C# que recebe dois números inteiros 
como parâmetros e retorna a soma dos dois números:
*/

public int Soma(int a, int b)
{
    int resultado = a + b;
    return resultado;
}

int result = Soma(3, 5);
int result2 = Soma(10,15); 
int result3 = Soma(15,75); 
int result4 = Soma(12,54); 
int result5 = Soma(86,23); 
int result6 = Soma(2000,789); 
console.WriteLine(result);
console.WriteLine(result2);
console.WriteLine(result3);
console.WriteLine(result4);
console.WriteLine(result5);
console.WriteLine(result6);


/*
Sobrecarga é um tipo de polimorfismo estático (também conhecido como
 polimorfismo de compilação) e é um conceito fundamental na 
 programação orientada a objetos. A sobrecarga ocorre quando 
 duas ou mais funções na mesma escopo têm o mesmo nome, 
 mas diferentes listas de parâmetros (diferindo em número, 
 tipos e/ou ordem dos parâmetros).

Sobrecarga de método permite que você defina o mesmo nome 
de método várias vezes desde que a lista de parâmetros 
seja diferente para cada definição. Quando o método é 
chamado, a versão correta do método é resolvida em 
tempo de compilação com base nos argumentos que você passa.

Aqui está um exemplo de sobrecarga de método em C#:
*/
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}
/*
Neste exemplo, a classe Calculadora tem três métodos Somar. 
Um deles soma dois int, o outro soma dois double e o terceiro 
soma três int. Isso é um exemplo de sobrecarga de método. 
Quando você chama o método Somar, a versão correta do método
é selecionada com base nos argumentos que você passa.
*/


/*
Exercício 1: Crie uma classe chamada Matematica que possui um 
método chamado Multiplicar. Crie três versões deste método que 
recebam diferentes tipos e quantidades de parâmetros (dois inteiros, 
três inteiros, e dois doubles) e retornem o produto dos parâmetros.

Exercício 2: Crie uma classe chamada Circulo com dois métodos 
sobrecarregados chamados Area. Um método deve aceitar o raio 
como um inteiro e o outro deve aceitar o raio como um double. 
Ambos devem calcular e retornar a área do círculo.

Exercício 3: Crie uma classe chamada Imprimir com três métodos 
sobrecarregados: um que aceita uma string, um que aceita um 
inteiro e um que aceita um double. Cada método deve imprimir 
o argumento na console.
*/
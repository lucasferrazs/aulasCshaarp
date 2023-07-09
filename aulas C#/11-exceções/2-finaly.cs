/*
O bloco try-catch-finally é um construto de linguagem 
usado para lidar com exceções (erros em tempo de execução) 
de uma maneira controlada e previsível. Ele permite que você 
isole o código que pode lançar uma exceção e fornece um meio 
de capturar e lidar com a exceção, se ocorrer uma.

Aqui está a estrutura básica do bloco try-catch-finally em C#:
*/
try
{
    // Código que pode lançar uma exceção
}
catch (TipoDeExcecao ex)
{
    // Código para lidar com a exceção
}
finally
{
    // Código que será executado independentemente de uma exceção ser lançada ou não
}
/*
O bloco try contém o código que pode lançar uma exceção. 
Se uma exceção for lançada, o controle passará imediatamente 
para o bloco catch correspondente, se houver algum que possa 
lidar com o tipo de exceção lançada.

O bloco catch é onde você coloca o código para lidar com a exceção. 
O parâmetro ex contém detalhes sobre a exceção que foi lançada.

O bloco finally contém o código que será executado, independentemente 
de uma exceção ser lançada ou não. É útil para limpeza de recursos, 
como fechamento de arquivos ou conexões de rede, que você sempre deseja
 realizar, independentemente de ocorrer uma exceção. Se uma exceção é lançada, 
 o bloco finally será executado mesmo se nenhuma instrução catch corresponder à exceção.

Aqui está um exemplo simples:
*/
try
{
    int divisor = 0;
    int resultado = 10 / divisor;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Exceção capturada: " + ex.Message);
}
finally
{
    Console.WriteLine("Bloco finally sendo executado");
}
/*
Neste exemplo, estamos tentando dividir um número por zero, 
o que causa uma exceção DivideByZeroException. Capturamos 
essa exceção no bloco catch e imprimimos uma mensagem para 
o usuário. O bloco finally é executado após a execução do 
bloco try ou catch, imprimindo outra mensagem para o usuário.
*/
//Sem quebra de linha
Console.Write("Olá mundo! ");

//Com quebra de linha 
Console.WriteLine("Olá mundo! ");

//Escrevendo conteudo com ponto flutuante

double x = 10.35245;

Console.WriteLine(x);

Console.WriteLine(x.ToString("F2"));//usando o ToString nós 
//podemos escolher quantas casas decimais irão aparaecer
Console.WriteLine(x.ToString("F4"));

//Concatenação , juntando texto com variaveis

Console.WriteLine("o seu Troco deu " + x + " reais ");
Console.WriteLine("o seu Troco deu " + x.ToString("F2") + " reais ");

string nomePaciente = "Maria";
int idadePaciente = 65;
char sexoPaciente = "F";



Console.WriteLine("a paciente " + nomePaciente + " Tem " + idadePaciente 
                    + " anos e é do sexo : " + sexoPaciente);

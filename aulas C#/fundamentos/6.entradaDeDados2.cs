int n1 = int.Parse(Console.ReadLine());
/* o comando int.Parse é ultilizado para transformar a informação
que esta chegando no Console em um numero inteiro ja que todas as informações por padrao 
chegam como uma string
*/
char ch = char.Parse(Console.ReadLine());
/*
o comando char tem a mesma função de mudar o tipo do dado que esta
entrando , com a direfença que ele muda para o tipo char
*/
double db = double.Parse(Console.ReadLine());
/*
o comando double tem a mesma função de mudar o tipo do dado que esta
entrando , com a direfença que ele muda para o tipo double
*/
string[] p = Console.ReadLine().Split(' ');

string nome = p[0];
double altura = double.Parse(p[1]);
int idade = int.Parse(p[2]);
char sexo = char.Parse(p[3]);

Console.WriteLine(nome + " Tem " + idade + " anos " + " Mede " +
 altura + " Seu sexo é :" + sexo);



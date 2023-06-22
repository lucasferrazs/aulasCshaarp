//o comando ultilizado para a entrada de dados é Console.ReadLine();
/*
os dados capturados pelo Console.ReadLine() são sempre armazenados 
em forma de string 
*/

string frase = Console.ReadLine();

/*
o comando split é ultilado quando nós queremos
guardar mais de uma varivel vindo de um mesmo texto
usando esse comando , nós podemos configurar cada espaço em branco
indicando que ele é o meu separador de elementos
*/
string s = Console.ReadLine();
string[] vet= s.Split(' ');
string p1  = vet[0];
string p2  = vet[1];
string p3  = vet[2]; 
Console.WriteLine(p1 + " " + p2 + " " + , p3);

//exemplo 2 de split

string[] v = Console.ReadLine().Split(' ');

string p4  = v[0];
string p5  = v[1];
string p6  = v[2];

Console.WriteLine(p4 + " " + p5 + " " + , p6);
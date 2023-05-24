/* o casting é utilizado quando o sistema não consegue entender 
qual o tipo da varivel que você deseja processar , ou quando voce 
necessita mudar o tipo da variavel
*/
//Exemplo
int x1,y1;
double resposta;

x1=5;
y1 = 2;      
      
resposta = x1 + y1;

Console.WriteLine(resposta);

//

int x1,y1;
double resposta;

x1=5;
y1 = 2;      
      
resposta = (double)x1 / y1;//

Console.WriteLine(resposta);
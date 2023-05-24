int x = 5;

//estrutura condicional simples
if(x > 0){
    Console.Write("Bom dia !");
}

//estrutura condicional composta
if(x < 0){
     Console.Write("Boa tarde !");
}
else {
     Console.Write("Boa noite !");
}

//encadeamento de estruturas condicionais

if(x <= 12){
    Console.Write("Bom dia");
}else{
    if(x >12 && x <= 18){
        Console.Write("Boa tarde");
    }else{
        Console.Write("Boa noite");
    }
}

//outro tipo de encadeamento de condições


if(x <= 12){
    Console.Write("Bom dia");
}else if(x > 12 && x <= 18){
    Console.Write("Boa tarde");
}
else {
    Console.Write("Boa noite");
}


// See https://aka.ms/new-console-template for more information

//Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.


int[] dias = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,
16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};

double[] valor = {22174.1664,24537.6698,26139.6134,0.0, 0.0,26742.6612, 0.0
,42889.2258,46251.174,11191.4722,0.0,0.0,3847.4823,373.7838,2659.7563,48924.2448,18419.2614
,0.0,0.0,35240.1826,43829.1667,18235.6852,4355.0662,13327.1025,0.0,0.0,25681.8318
,1718.1221,13220.495, 8414.61};

double menorValor = valor[0];
double maiorValor = valor[0];
int dia = 0;
double soma = 0;
double media = 0;

//            Menor valor
for(int i =0; i < valor.Length; i++)
{
   if(valor[i] < menorValor){
    if(valor[i] == 0){
     continue;
    }
     menorValor = valor[i];
     dia = dias[i];
   }
   
}
Console.WriteLine("Menor valor de faturamento:");
Console.WriteLine($"Dia: {dia}, Valor: {menorValor}\n");

//-------------------------------------------------------------------------------

//                    Maior Valor
for(int i =0; i < valor.Length; i++)
{
   if(valor[i] > maiorValor){
    if(valor[i] == 0){
     continue;
    }
     maiorValor = valor[i];
     dia = dias[i];
   }
   
}
Console.WriteLine("Maior valor de faturamento:");
Console.WriteLine($"Dia: {dia}, Valor: {maiorValor}\n");

//-------------------------------------------------------------------------------

//                    Média
Console.WriteLine("Média Mensal:\n");
for(int i =0; i < valor.Length; i++)
{
    if(valor[i]==0){
        continue;
    }
   soma += valor[i];
   dia = dias[i];
   media = soma / valor.Length;
   Console.WriteLine($"Dia: {dia}, Média Mensal: {media}");
}






// See https://aka.ms/new-console-template for more information

//Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

//SP – R$67.836,43
//RJ – R$36.678,66
//MG – R$29.229,88
//ES – R$27.165,48
//Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

double sp =67.83643;
double rj = 36.67866;
double mg = 29.22988;
double es = 27.16548;
double outros = 19.84953;
double total = 0;

total = sp + rj + mg + es + outros;
Console.WriteLine($"Total: {total}\n");

double PesSp = (sp*100)/total;
Console.WriteLine($"Percentual SP: {PesSp}");

double PesRj = (rj*100)/total;
Console.WriteLine($"Percentual RJ: {PesRj}");

double PesMg = (mg*100)/total;
Console.WriteLine($"Percentual MG: {PesMg}");

double PesEs = (es*100)/total;
Console.WriteLine($"Percentual ES: {PesEs}");

double PesOutr = (outros*100)/total;
Console.WriteLine($"Percentual Outros: {PesOutr}");
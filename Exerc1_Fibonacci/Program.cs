// See https://aka.ms/new-console-template for more information

// Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
// (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, 
//informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

int valor1 = 0;
int valor2= 0;
 Console.Write("Informe um Valor: ");
int valor3 = Convert.ToInt32(Console.ReadLine());
Console.Clear();


    if(valor3 < valor2){
        Console.WriteLine("Esse número não pertence a sequência de Fibonacci");
    }
    else{
        Console.WriteLine("Esse número pertence a sequência de Fibonacci");
        while(valor3 > valor2)
            {
                valor2=valor1;
                valor1=valor3;
                valor3=valor1+valor2;

                Console.WriteLine(valor2);
            }
    };

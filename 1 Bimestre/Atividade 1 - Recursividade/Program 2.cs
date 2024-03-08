//Primeira lista de exercícios de Estrutura de Dados(2 ao 6) - FATEC Presidente Prudente - Feito em 23/03/23 . By: Andres Kaique 

string op1 = "0";
while (op1 != "6")
{
    Console.Clear();
    Console.WriteLine("\nMENU DE EXERCICIOS\n\n1 - POTENCIAS (EX 2)\n2 - CUBOS(EX 3)\n3 - ALGORITIMO DE EUCLIDES (EX 4)\n4 - FIBONACCI (EX 5)\n5 - BASE BINÁRIA (EX 6)\n6 - FINALIZAR PROGRAMA");
    Console.Write("DIGITE A OPÇÂO DESEJADA: ");
    op1 = Console.ReadLine();

    int x,y=0;
    
    if (op1 == "1")
    {
        Console.Write("Digite o número de x que vai ser elevado a potencia: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor da potencia: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"potencia de {x} elevado a {y} é igual a {Exercise2(x,y)}");
        break;
    }
    
    else if (op1=="2")
    {
        Console.Write("Função calculadora do cubo de números POSITIVOS. Exibe valores do 1 ao número digitado.");
        Console.Write("Digite o valor da iteração: ");
        x = Convert.ToInt32(Console.ReadLine());
        Exercise3(x);
        break;
    }

    else if (op1=="3")
    {
        Console.Write("Digite o número de x (Para obter o MDC) ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o número de y (Para ober o MDC): ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O maximo divisor comum de {x} com {y} é {Exercise4(x,y)}");
        break;
    }
    else if (op1=="4")
    {
        Console.Write("Digite o número de x (Para o calculo da Série de Fibonacci) ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{Exercise5(x)}");
        break;
    } 

    else if(op1=="5")
    {
        Console.Write("Digite o número que vai ser convertido para a base binária: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor do número {x} na base binária é ");
        Exercise6(x);   
        break;
    }
    else if (op1=="6"){
        break;
    }
    Console.ReadKey();
}

int Exercise2(int NumBase, int expoente)
{
    if (expoente>1)
    {
        return NumBase * Exercise2(NumBase, expoente-1);
    }
    else
    {
        return NumBase;
    }
}

void Exercise3 (int xCube)
{   
    if (xCube>0)
    {
        Exercise3(xCube-1);
        int cube = xCube*xCube*xCube;
    //for (int i = 1; i <= n; i++)
        Console.WriteLine($"Número {xCube} ao cubo é {cube}");
    }
}

int Exercise4(int xMDC, int yMDC)
{
    if (yMDC==0)
    {
        return xMDC;
    }
    else
    {
        return Exercise4(yMDC,xMDC%yMDC);
    }
}

int Exercise5(int xFibo)
{
    if (xFibo == 0 | xFibo == 1)
    {
        return xFibo;
    }
    else
    {
        return Exercise5(xFibo-1) + Exercise5(xFibo - 2);
    }
}

void Exercise6(int xBin)
{
    if (xBin > 0)
    {
        Exercise6(xBin/2);
        Console.WriteLine(xBin%2);
    }
}
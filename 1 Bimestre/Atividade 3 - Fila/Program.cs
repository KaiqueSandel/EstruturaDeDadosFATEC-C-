const int MAX = 20;

int[] fila = new int[MAX];
int inicio  = 0, fim = 0 ;

bool rodar_programa = true;
string op;

while (rodar_programa)
{
    Console.WriteLine("\n***********CONTROLE DE PISTA***********\n");
    Console.WriteLine("1 - Adicionar avião na fila");
    Console.WriteLine("2 - Consultar quantidade de aviões na fila");
    Console.WriteLine("3 - Autorizar decolagem");
    Console.WriteLine("4 - Consultar id dos aviões na fila");
    Console.WriteLine("5 - Consultar o primeiro avião da fila");
    Console.WriteLine("0 - Encerrar o programa");
    Console.Write("\nDigite a opção desejada: ");
    op = Console.ReadLine();

    if (op == "1")
    {
        if (!EstaCheia(fim))
        {
            adicionar();
        }
        else
        {
            System.Console.WriteLine("A fila se encontra cheia... Não é possivel adicionar o avião a fila");
        }
    }
    else if(op == "2")
    {
        quantidadeFila();
    }
    else if(op == "3")
    {
        if(!EstaVazia(inicio, fim))
        {
            autorizacao();
        }
        else
        {
            System.Console.WriteLine("Nenhum avião na fila.");
        }
    }
    else if (op == "4")
    {
        if (!EstaVazia(inicio,fim))
        {
            consultarID();
        }
        else
        {
            System.Console.WriteLine("Nenhum avião na fila para ser consultado.");
        }
    }
    else if (op == "5")
    {
        if (!EstaVazia(inicio,fim))
        {
            consultarPrimeiroID();
        }
        else
        {
            System.Console.WriteLine("Nenhum avião na fila para ser consultado.");
        }
    }
    else if(op == "0")
    {
        System.Console.WriteLine("Programa finalizado");
        rodar_programa = false;
    }
}

void adicionar()
{
    System.Console.Write("\nAdicionar avião na fila\n");
    System.Console.WriteLine("Digite o ID do avião que deseja adicionar na fila: ");
    int id = int.Parse(Console.ReadLine());
    Insere(fila, ref fim, id);
    System.Console.WriteLine("Avião ID {0} adicionado com sucesso na fila",id);
}

void quantidadeFila()
{
    System.Console.WriteLine("\nConsulta quantidade de aviões na fila\n");
    int calculo = fim - inicio;
    System.Console.WriteLine(calculo + " aviões estão na fila de decolagem.");
}

void autorizacao()
{
    Console.WriteLine("\nAutorização de decolagem\n");
    Console.WriteLine("Deseja autorizar a decolagem do avião ID {0}? S - Sim / N - não",fila[inicio]);
    Console.Write("Digite a opção desejada: ");
    string autorizado = Console.ReadLine();
    if (autorizado == "S" || autorizado == "s")
    {
        int aviaoAutorizado = Remove(fila, ref inicio);
        Console.WriteLine("Avião ID {0} autorizado a decolagem.", aviaoAutorizado);
    }
    else
    {
        Console.WriteLine("Nenhum avião foi autorizado a decolar.");
    }
}

void consultarID()
{
    System.Console.WriteLine("\nConsulta dos IDs dos aviões na fila");
    for(int i = inicio; i < fim; i++)
    {
        System.Console.WriteLine("Posição do avião na fila {0}. ID do avião é {1}",i,fila[i]);
    }
}

void consultarPrimeiroID()
{
    System.Console.WriteLine("\nConsulta do primeiro avião na fila\n");
    System.Console.WriteLine("O avião ID {0} é o primeiro avião da fila.",fila[inicio]);
}


bool EstaVazia(int i, int f)
{
    if (i == f)
        return true;
    else
        return false;
}

bool EstaCheia(int f)
{
    if (f == MAX)
        return true;
    else
        return false;
}

void Insere(int[] q, ref int f, int v)
{
    q[f] = v;
    f = f + 1;
}

int Remove(int[] q, ref int i)
{
    int v = q[i];
    i = i + 1;
    return (v);
}
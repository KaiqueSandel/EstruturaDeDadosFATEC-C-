//Implemente um programa que conte a quantidade de colisões ocorridas durante o processo de inserção. Utilize o tratamento de colisão linear. O vetor deve ser de um tipo abstrato de dado composto por nota, nome e email. A nota deve ser um número inteiro e corresponderá a chave.
//O menu deve conter as seguintes opções: Inserir, Recuperar e Informar. Na opção recuperar, solicite a nota e caso encontre-a no vetor, exiba o nome e o email correspondente, caso contrário, exiba a mensagem de nota não encontrada. A opção informar, informa a quantidade de colisões ocorridas até o momento.



const int N = 5;

int Hash(int chave)
{
   return (chave % N);
}

void InsereLinear(Dado[] v, int nota, string nome, string email, ref int colisao)
{
   int pos = Hash(nota);
   while (v[pos]  != null)
   {
      pos++;
      pos = pos % N;
      colisao++;
   }
    Dado novodado = new Dado();
    novodado.Nota = nota;
    novodado.Nome = nome;
    novodado.Email = email;
    v[pos] = novodado;
    System.Console.WriteLine("O aluno foi cadastrado com sucesso!");
}

void Recuperar(Dado[] v, int c)
{
    int pos = Hash(c);
    while (v[pos] != null)
    {
        if(v[pos].Nota == c) 
        {
            System.Console.WriteLine("Nota do aluno: " +v[pos].Nota);
            System.Console.WriteLine("Nome do aluno: " +v[pos].Nome);
            System.Console.WriteLine("Email do aluno:" +v[pos].Email);
            return;
        }
        pos++;
        pos = pos % N;
    }
    System.Console.WriteLine("Nota não encontrada.");
}

Dado[] vetor = new Dado[N];
string op = "1";
int colisao = 0;

while (op != "0")
{
    System.Console.WriteLine("MENU PRINCIPAL\n");
    System.Console.WriteLine("1 - Inserir");
    System.Console.WriteLine("2 - Recuperar");
    System.Console.WriteLine("3 - Informar");
    System.Console.WriteLine("0 - Sair");

    System.Console.Write("Digite a opção desejada: ");
    op = System.Console.ReadLine();

    if(op == "1")
    {
        System.Console.Write("Digite a nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        System.Console.Write("Digite o email: ");
        string email = Console.ReadLine();
        InsereLinear(vetor, nota, nome, email, ref colisao);
    }

    else if(op == "2")
    {
        System.Console.Write("Digite a nota a ser recuperada: ");
        int nota_procurada = Convert.ToInt32(Console.ReadLine());
        Recuperar(vetor,nota_procurada);
    }

    else if(op == "3")
    {
        System.Console.WriteLine("Quantidade de colisões ocorridas: " + colisao);
    }

    else if (op == "0")
    {
        System.Console.WriteLine("Saindo do modulo da aplicação....");
    }
}

class Dado
{
    public int Nota = 0;
    public string Nome = "";
    public string Email = "";
}
const int MAX = 20;
char[] pilha = new char[MAX];
int topo = 0;

void Insere(char[] p, ref int t, char v)
{
    p[t] = v;
    t = t + 1;
}

char Remove(char[] p, ref int t)
{
    t = t - 1;
    return (p[t]);
}

string frase = "";
Console.Write("Digite uma frase: ");
frase = Console.ReadLine();
frase = String.Format("{0} ", frase);
int i = 0;

while (i < frase.Length-1)
{
    while(frase[i] != ' '&& i < frase.Length)
    {
        Insere(pilha, ref topo, frase[i]);
        i++;
    }
    while(topo > 0)
    {
        char removed = Remove(pilha, ref topo);
        System.Console.Write(removed);
    }
    System.Console.Write(' ');
    i++;

}
void Insere(ref tp_no r, int x)
{
   if (r == null)
   {
      r = new tp_no();
      r.valor = x;
   }
   else if (x < r.valor)
      Insere(ref r.esq, x);
   else
      Insere(ref r.dir, x);
}

tp_no Busca(tp_no r, int x)
{
   if (r == null)
      return null;
   else if (x == r.valor)
      return r;
   else if (x < r.valor)
      return Busca(r.esq, x);
   else
      return Busca(r.dir, x);
}

tp_no Remove(ref tp_no r, int x)
{
   if (r == null)
      return null;     
   else if (x == r.valor)
   {       
      tp_no p = r;
      if (r.esq == null)        // nao tem filho esquerdo
         r = r.dir;
      else if (r.dir == null)  // nao tem filho direito
         r = r.esq;
      else                          // tem ambos os filhos
      {
         p = RetornaMaior(ref r.esq);
         r.valor = p.valor;
      }
      return p;
   }
   else if (x < r.valor)
      return Remove(ref r.esq, x);
   else
      return Remove(ref r.dir, x);
}

tp_no RetornaMaior(ref tp_no r)
{
   if (r.dir == null)
   {
      tp_no p = r;
      r = r.esq;
      return p;
   }
   else
      return RetornaMaior(ref r.dir);
}

void PreOrdem(tp_no r)
{
   if (r != null)
   {
      Console.WriteLine(r.valor);
      PreOrdem(r.esq);
      PreOrdem(r.dir);
   }
}

void PosOrdem(tp_no r)
{
   if (r != null)
   {
      PosOrdem(r.esq);
      PosOrdem(r.dir);
      Console.WriteLine(r.valor);
   }
}

tp_no raiz = null,x;
string main_option = "1";
string Exercise27_option = "";
string Option_print = "";
int valor;


//principal
while (main_option != "0")
{
    Console.WriteLine("\nMENU PRINCIPAL\n1 - Inserir Valor\n2 - Pesquisar Valor\n3 - Remover Valor\n4 - Exibir Valores\n0 - Sair\n");
    Console.Write("Digite a opção desejada: ");
    Exercise27_option = Console.ReadLine();

    if (Exercise27_option == "1")
    {
      Console.Write("Digite o valor a ser adicionado: ");
      valor = Convert.ToInt32(Console.ReadLine());
      Insere(ref raiz, valor);
    }
    else if (Exercise27_option == "2")
    {
      Console.Write("Digite o valor a ser consultado: ");
      valor = Convert.ToInt32(Console.ReadLine());
      x = Busca(raiz, valor);
      if (x != null)
      {
         Console.WriteLine("Valor encontrado\n");
      }
      else
      {
         Console.WriteLine("Valor não encontrado\n");
      }

    }
    else if (Exercise27_option == "3")
    {
      Console.Write("Digite o valor a remover: ");
      valor = Convert.ToInt32(Console.ReadLine());
      x = Remove(ref raiz, valor);
      if (x != null)
      {
         Console.WriteLine("Valor removido com sucesso!\n");
      }
      else
      {
         Console.WriteLine("Valor não foi removido!\n");
      }

    }
    else if (Exercise27_option == "4")
    {
      Console.WriteLine("1 - Pré Ordem / 2 - Pós Ordem\n");
      Console.Write("Digite a opção desejada: ");
      Option_print = Console.ReadLine();
      if (Option_print == "1")
      {
         PreOrdem(raiz);
      }
      else if (Option_print == "2")
      {
         PosOrdem(raiz);
      }
      else
      {
         Console.WriteLine("Opção inválida...\n");
      }
    }
    else if (Exercise27_option == "0")
    {
        Console.WriteLine("Encerrando a aplicação....\n");
        main_option = "0";
    }
    else
    {
        Console.WriteLine("Opção inválida... Tente novamente...\n");
    }
}

class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;
}

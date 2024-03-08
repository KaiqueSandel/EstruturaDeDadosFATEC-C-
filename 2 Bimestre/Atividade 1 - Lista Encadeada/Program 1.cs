void Exercise20_Insert(ref tp_no l, string name, string age, string whatsapp)
{
    tp_no no = new tp_no();
    no.exercise20_name = name;
    no.exercise20_age = age;
    no.exercise20_whatsapp = whatsapp;
    if (l != null)
        no.prox = l;
    l = no;
}

void Exercise20_Query(tp_no l, string name_wanted, ref tp_no current, ref tp_no before)
{
    before = null;
    current = l;

    while(current != null && name_wanted != current.exercise20_name)
    {
        before = current;
        current = current.prox;
    }
}

void Exercise20_Print(tp_no l)
{
    tp_no assistant = l;
    int i = 1;
    while(l != null)
    {
        System.Console.WriteLine("\nRegistros "+i+"\nNome: "+l.exercise20_name+"\nIdade: "+l.exercise20_age+"\nWhatsApp: "+l.exercise20_whatsapp);
        i++;
        l = l.prox;
    }
}

void Exercise20_Delete(ref tp_no l)
{   
    tp_no current = null;
    tp_no anterior = null;
    string np;
    System.Console.Write("Digite o nome procurado: ");
    np = Console.ReadLine();
    Exercise20_Query(l, np, ref current, ref anterior);
    if (current != null)
    {
        if(current == l)
        {
            l = l.prox;
            current.prox = null;
        }

        else if(current.prox == null)
        {
            anterior.prox = null;
        }

        else
        {
            anterior.prox = current.prox;
            current.prox = null;
        }
        System.Console.WriteLine("Exclusão completa.");
    }

    else
    {
        System.Console.WriteLine("Não encontrado.");
    }
}

tp_no lista = null;
string exercise20_option = "1";
string exercise20_name, exercise20_age, exercise20_whatsapp = "";

while (exercise20_option != "0")                                                 
{
        System.Console.WriteLine("\n1 - Inserir\n2 - Alterar\n3 - Excluir\n4 - Exibir\n0 - Sair");
        System.Console.WriteLine("\nDigite a opção desejada: ");
        exercise20_option = Console.ReadLine();
        if(exercise20_option == "1")
        {
            System.Console.Write("Digite o nome: ");
            exercise20_name = Console.ReadLine();
            System.Console.Write("Digite a idade: ");
            exercise20_age = Console.ReadLine();
            System.Console.Write("Digite o WhatsApp: ");
            exercise20_whatsapp = Console.ReadLine();
            Exercise20_Insert(ref lista, exercise20_name, exercise20_age, exercise20_whatsapp);
        }

        else if(exercise20_option == "2")
        {
            string name_wanted;
            tp_no current = null;
            tp_no before = null;
            System.Console.Write("Digite o nome para consulta: ");
            name_wanted = Console.ReadLine();
            Exercise20_Query(lista, name_wanted, ref current, ref before);
            if(current !=null)
            {
                System.Console.WriteLine("Dados Atuais");
                System.Console.WriteLine("Nome "+ current.exercise20_name);
                System.Console.WriteLine("Idade "+ current.exercise20_age);
                System.Console.WriteLine("WhatsApp "+ current.exercise20_whatsapp);
                System.Console.WriteLine("Digite os novos dados!");
                System.Console.Write("Nome: ");
                current.exercise20_name = Console.ReadLine();
                System.Console.Write("Idade: ");
                current.exercise20_age = Console.ReadLine();
                System.Console.Write("WhatsApp ");
                current.exercise20_whatsapp = Console.ReadLine();
            }

            else
                {
                    System.Console.WriteLine("\nNão encontrado!");
                }
        }

        else if (exercise20_option == "3")
        {
            Exercise20_Delete(ref lista);
        }

        else if (exercise20_option == "4")
        {
            Exercise20_Print(lista);
        }

        else if(exercise20_option == "0")
        {
            System.Console.WriteLine("Encerrando aplicação... ");
            exercise20_option = "0";
        }
        
        else
        {
            System.Console.WriteLine("Opção inválida, tente novamente.");
        }
}

class tp_no
{
    public string exercise20_name, exercise20_age, exercise20_whatsapp;
    public tp_no prox = null;
}
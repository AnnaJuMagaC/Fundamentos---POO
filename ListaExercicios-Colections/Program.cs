internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******************** Atividade 01 ******************\n");

        //Criando uma lista de Tarefas
        List<string> tarefas = new List<string>();
        tarefas.Add("Tomar café da manhã");
        tarefas.Add("Escovar dentes");
        tarefas.Add("Ir a escola");
        tarefas.Add("Estudar");
        tarefas.Add("Almoçar");
        tarefas.Add("Arrumar Casa");
        tarefas.Add("Jantar");
        tarefas.Add("Dormir");

        //1
        tarefas.Insert(2, "Me arrumar");

        //2
        tarefas[4] = "Fazer almoço e comer";

        //3
        bool achou = tarefas.Contains("Estudar");
        if (achou)
            Console.WriteLine("A tarefa 'Estudar' foi encontrada na lista.");
        else
            Console.WriteLine("A tarefa 'Estudar' não foi encontrada na lista.");

        //4
        tarefas.Remove("Arrumar Casa");

        //5
        foreach (string item in tarefas)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n******************** Atividade 02 ******************\n");

        Dictionary<string, string> agenda = new Dictionary<string, string>();

        agenda.Add("Yaya", "999999999");
        agenda.Add("Bia", "888888888");
        agenda.Add("Ray", "777777777");
        agenda.Add("Bagi", "666666666");
        agenda.Add("Pedro", "555555555");

        Console.WriteLine("\nAlterando os valores do 'Dicionário'");
        agenda["Bagi"] = "333333333";

        bool contatoExiste = agenda.TryGetValue("Pedro", out string numero);
        if (contatoExiste)
            Console.WriteLine($"O número do contato 'Pedro' é: {numero}");
        else
            Console.WriteLine("Contato 'Pedro' não encontrado.");

        agenda.Remove("Ray");

        foreach (var item in agenda)
        {
            Console.WriteLine($"Nome: {item.Value}, Telefone: {item.Key}");
        }

        Console.WriteLine("\n******************** Atividade 03 ******************\n");


        Queue<string> filaSuporte = new Queue<string>();

        filaSuporte.Enqueue("Yaya");
        filaSuporte.Enqueue("Bia");
        filaSuporte.Enqueue("Ray");
        filaSuporte.Enqueue("Bagi");
        filaSuporte.Enqueue("Pedro");

        string primeiroDaFila = filaSuporte.Dequeue();
        Console.WriteLine($"A primeira pessoa da fila de suporte, {primeiroDaFila}, já foi atendida");

        bool procurar = filaSuporte.Contains("Bagi");
        if (procurar)
            Console.WriteLine("\nBagi está na fila de suporte.");
        else
            Console.WriteLine("\nBagi não está na fila de suporte.");

        string segundoDaFila = filaSuporte.Dequeue();
        Console.WriteLine($"\nA primeira pessoa da fila de suporte, {segundoDaFila}, já foi atendido ");

        foreach (string item in filaSuporte)
        {
            Console.WriteLine($"\nAtendendo: {item}");
        }

        Console.WriteLine("\n******************** Atividade 04 ******************\n");

        Stack<string> historico = new Stack<string>();

        historico.Push("Netflix");
        historico.Push("YouTube");
        historico.Push("Instagram");
        historico.Push("Facebook");
        historico.Push("Twitter");

        string excluirPagina = historico.Pop();
        Console.WriteLine($"\nA página retirada do historico foi: {excluirPagina}\n");
        foreach (var ultimaPagina in historico)
        {
            Console.WriteLine(ultimaPagina);
        }

        if (historico.Contains("Roblox"))
            Console.WriteLine("\nA URL foi encontrada");
        else
            Console.WriteLine("\nA URL não foi encontrada");

        string excluirPagina2 = historico.Pop();
        Console.WriteLine($"\nA página retirada do historico foi: {excluirPagina2}\n");
        foreach (var ultimaPagina in historico)
        {
            Console.WriteLine(ultimaPagina);
        }



    }
}
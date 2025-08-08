using Aula_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("****************** Trabalhando com Listas ******************");

        // Criando uma lista de strings
        List<string> lista = new List<string>();
        lista.Add("Maçã");    //Adiciona o item no final da lista
        lista.Add("Banana");  //Adiciona o item no final da lista
        lista.Add("Laranja"); //Adiciona o item no final da lista
        lista.Add("Uva");     //Adiciona o item no final da lista

        Console.WriteLine("\nImprimindo os valores da List na tela");
        foreach (string item in lista) //Percorre toda a lista
        {
            Console.WriteLine(item);  //Imprime itens por toda lista
        }

        Console.WriteLine("\nImprimir um item na posição específiac");
        Console.WriteLine($"Item na Posição 2:{lista[2]}"); //Imprime o item na posição 2 (Laranja)

        //Adicionar um item em uma posição específica
        Console.WriteLine("\nAdicionando um item na posição específica");
        lista.Insert(1, "Morango"); //Adiciona o item Morango na posição 1

        Console.WriteLine("\nImprimindo os valores da List na tela");
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        //Alterando um itemda lista
        Console.WriteLine("\nAlterando um item da lista especifico");
        lista[4] = "Abacaxi"; //Altera o item na posição 4 (Uva) para Abacaxi
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        //Removendo um item da lista
        Console.WriteLine("\nRemovendo um item da lista por posição");
        lista.RemoveAt(3); //Remove o item 3 da lista
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRemover um item da lista buscando pelo conteúdo");
        lista.Remove("Abacaxi"); //Remove o item Abacaxi da lista
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRemover todos os itens da lista");
        lista.Clear(); //Remove todos os itens da lista
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n========================================================\n");

        //Criando uma lista de Alunos
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adiciona o item no final da lista
        listaAlunos.Add(new Aluno(1, "Anna"));

        //Adiciona o item final da lista
        listaAlunos.Add(new Aluno(2, "Bia"));
        listaAlunos.Add(new Aluno(3, "Yaya"));
        listaAlunos.Add(new Aluno(4, "Pedro"));
        listaAlunos.Add(new Aluno(5, "Bagi"));
        listaAlunos.Add(new Aluno(6, "Ray"));

        Console.WriteLine("Imprimindo os valores do 'List' de Alunos na tela");
        foreach (Aluno aluno in listaAlunos) //Percorre toda a lista
        {
            //Imprimir item por item da lista
            Console.WriteLine($"Código: {aluno.Codigo} - Nome: {aluno.Nome}");
        }

        Console.WriteLine("\n========================================================\n");

        //Criando um dicionário de dados
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        //Adicionando itens ao dicionário
        dicionario.Add(10, "Ka");
        dicionario.Add(20, "Fusca");
        dicionario.Add(30, "Civic");
        dicionario.Add(40, "Corolla");

        //Imprimindo os valores do dicionário na tela
        Console.WriteLine("Imprimindo os valores do 'Dicionário' na tela");
        foreach (KeyValuePair<int, string> item in dicionario)
        {
            //Imprime chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        //Forma mais comum e mais facíl, UTILIZANDO var
        Console.WriteLine("\nImprimindo os valores do 'Dicionário' na tela foreach");
        foreach (var item in dicionario)
        {
            //Imprime chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        Console.WriteLine("\nAlterando os valores do 'Dicionário'");
        dicionario[10] = "Corsa"; //Altera o valor da chave 10 para Fusca
        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        //Pesquisando um item no dicionário por valor
        Console.WriteLine("\nPesquisar um item no dicionário por chave");
        string carro;

        bool carroExiste = dicionario.TryGetValue(30, out carro);

        if (carroExiste)
        {
            Console.WriteLine($"O valor encontrado para a chave 30 é: {carro}");
        }
        else
        {
            Console.WriteLine("A chave 30 não foi encontrada");
        }

        //Excluindo um item do dicionário
        dicionario.Remove(30); //Remove o item da chave 30


        Console.WriteLine("\n========================================================\n");

        //Criando uma coleçaõ de dados do tipo fila
        Console.WriteLine("Trabalhando com Fila");
        Queue<string> fila = new Queue<string>();

        //Adicionar elementos da fila (Queue => Fila)
        fila.Enqueue("Anna"); //Adiciona o primeiro item na fila
        fila.Enqueue("Yaya");  //Adiciona o segundo item na fila
        fila.Enqueue("Pedro");  //Adiciona o terceiro item na fila
        fila.Enqueue("Bia");  //Adiciona o quarto item na fila
        fila.Enqueue("Bagi");  //Adiciona o quinto item na fila
        fila.Enqueue("Ray");  //Adiciona o sexto item na fila
        fila.Enqueue("Justen");  //Adiciona o setimo item na fila
        foreach (var pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }

        //Tirar os elementos da fila
        string primeiroDaFila = fila.Dequeue();
        Console.WriteLine($"\n{primeiroDaFila} é o primeiro, e saiu\n");
        foreach (var pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }

        //Todo novo item é inserido no final da fila
        Console.WriteLine("\nAdicionando um novo item na fila (vai pra o final dela)");
        fila.Enqueue("Anna");
        foreach (var pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }

        //Procurara por um elemento na fila
        bool achou = fila.Contains("Bia");
        //Não é necessário chave no 'if' caso seja apenas uma linha de código
        if (achou)
            Console.WriteLine("\nNome encontrado");
        else
            Console.WriteLine("\nO nome não está na lista");

        Console.WriteLine("\n========================================================\n");

        //Criando uma coleção do tipo Pilha (Stack)
        Console.WriteLine("Trabalhando com Pilha");
        Stack<string> pilha = new Stack<string>();

        //Adicionar elementos na pilha (Stack => Pilha)
        pilha.Push("Harry Potter");
        pilha.Push("Jogos Vorazes");
        pilha.Push("As vantagens de ser invisível");

        //Imprimir elementos da pilha
        foreach (var livro in pilha)
        {
            Console.WriteLine(livro);
        }

        //Remover o primeiro item da pilha
        string livroRetirado = pilha.Pop();
        Console.WriteLine($"\nO livro retirado da pilha foi: {livroRetirado}\n");
        foreach (var livro in pilha)
        {
            Console.WriteLine(livro);
        }

        //Pesquisar um item da pilha
        if (pilha.Contains("Harry Potter"))
            Console.WriteLine("\nO livro foi encontrado");
        else
            Console.WriteLine("\nO livro não foi encontrado");

        Console.WriteLine("\n========================================================\n");

        //Criando uma coleção do tipo HashSet (uma lista que não permite itens repetidos)
        Console.WriteLine("Trabalhando com HashSet");
        HashSet<string> listaUnica = new HashSet<string>();

        //Adicionando itens na HashSet
        listaUnica.Add("Maçã");
        listaUnica.Add("Banana");
        listaUnica.Add("Laranja");
        listaUnica.Add("Uva");

        //Tentando adicionar um item repetido
        listaUnica.Add("Maçã");

        //Imprime a lista unica
        foreach (var unica in listaUnica)
        {
            Console.WriteLine(unica);
        }

        //Remover um item da lista unica
        Console.WriteLine("\nRemovendo um item da lista única");
        listaUnica.Remove("Banana");
        foreach (var unica in listaUnica)
        {
            Console.WriteLine(unica);
        }

        //Procurar um elemento n HashSet

        if (listaUnica.Contains("Manga"))
            Console.WriteLine("\nO item foi encontrado na lista única");
        else
            Console.WriteLine("\nO item não foi encontrado na lista única");

        Console.WriteLine("\n========================================================\n");


    }
}

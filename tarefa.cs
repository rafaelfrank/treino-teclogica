namespace GerenciadorTarefas;

public class Tarefa
{
    public int id {get; set; }
    public string titulo {get; set; } = string.empty;
    public bool concluida {get; set; }

    public void exibir ()
    {
        string status = concluida ? "sim" : "nao";
        Console.WriteLine($ "{id} - {status} {titulo}")
    }
}



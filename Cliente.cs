class Cliente
{
    private string? nome;
    private int telefone; // mudei pra int

    // Construtor coisado pra int
    public Cliente(string? nome, int telefone)
    {
        this.nome = nome;
        this.telefone = telefone;
    }

    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Telefone // mudei pra int
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public override string ToString()
    {
        return $"[CLIENTE] Nome: {nome} | Telefone: {telefone}";
    }
}

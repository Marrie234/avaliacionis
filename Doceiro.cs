class Doceiro
{
    private string? nome;
    private string especialidade;
  
    //Adicionei os parenteses e os parametros do construtor
    public Doceiro(string? nome, string especialidade)
    {
        this.nome = nome;
        this.especialidade = especialidade;
    }

    //mudei para string? pra bater certo com a variável privada nome
    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Especialidade
    {
        get { return especialidade; }
        set { especialidade = value; }
    }

    public override string ToString()
    {
        return $"[DOCEIRO] Chef: {nome} | Especialidade: {especialidade}";
    }
}

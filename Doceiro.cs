class Doceiro
{
  private string? nome;
  private string especialidade;
  
  public Doceiro
     {
        this.nome = nome;
        this.especialidade = especialidade;
    }

    public string Nome
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

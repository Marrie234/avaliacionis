class Cliente
{
private string? nome;
private string telefone;
//construtor simples tbm
  public Cliente
  {
    //o this serve para o C# não se baralhar
    this.nome = nome;
    this.telefone = telefone;
  }
  public string? Nome
  {
    get{return sabor;}
    set{sabor = value;}
  }
  public string? Telefone
  {
    //o get retorna o valor e o set altera o valor
    get { return telefone; }
    set { telefone = value; }
  }
  //a ToString devolve uma frase organizada com o nome e o preço formatados e mais bunitim :).
  public override string ToString()
  {
     return $"[CLIENTE] Nome: {nome} | Telefone: {telefone}";
  }
}

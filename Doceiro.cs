class Doceiro
{
  private string? nome;
  private string especialidade;
  
  //mais um construtor simples
  public Doceiro
     {
            this.sabor = sabor;
            this.preco = preco;
        }

        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { if (value > 0) preco = value; }
        }

        public override string ToString()
        {
            return $"[DOCE] Sabor: {sabor} | Preço: R$ {preco:F2}";
        }
    }
}

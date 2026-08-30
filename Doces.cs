class Doce
{
    private string sabor;
    private string preco;

    // Construtor simples
    public Doce;
    {
        this.sabor = sabor;
        this.preco = preco;
    }

    public string Sabor
    {
        get { return sabor; }
        set { sabor = value; }
    }

    public string Preco
    {
        get { return preco; }
        set 
        { 
            if (value > 0) preco = value; 
        }
    }

    public override string ToString()
    {
        return $"[DOCE] Sabor: {sabor} | Preço: R$ {preco:F2}";
    }
}

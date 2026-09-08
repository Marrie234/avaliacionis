class Doce
{
    private string sabor;
    private decimal preco; // Tipo ideal para dinheiro/moeda

    public Doce(string sabor, decimal preco)
    {
        this.sabor = sabor;
        this.preco = preco;
    }

    public string Sabor
    {
        get { return sabor; }
        set { sabor = value; }
    }

    public decimal Preco
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

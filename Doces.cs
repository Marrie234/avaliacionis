class Doce;
{
    private string? sabor;
    private int preco;
    public string? Nome;
{
    get
    {
        Console.WriteLine("Procurando sabor...");
        return sabor;
    }
        set
    {
            if (value == null)
            {
                Console.WriteLine("Tem que ter sabor");
            }
            else
            {
                Console.WriteLine("Definindo nome. . .");
                nome = value;
            }
        }
}
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("=== EXIBINDO DADOS INICIAIS ===");
        
        Cliente c1 = new Cliente("Ana Silva", "25120-1822");
        Cliente c2 = new Cliente("Carlos Souza", "95488-2522");

        Doceiro d1 = new Doceiro("Chef Amanda", "Bolos");
        Doceiro d2 = new Doceiro("Chef Lucas", "Brigadeiros");

        Doce doce1 = new Doce("Brigadeiro de Pistache", 4.50);
        Doce doce2 = new Doce("Fatia de Red Velvet", 12.00);

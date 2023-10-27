abstract public class Imovel
{
    public string endereco { get; set; } = string.Empty;
    public float preco { get; set; } = 350.000f;

    public Imovel (string endereco, float preco)
    {
        this.endereco = endereco;
        this.preco = preco;
    }


}

public class Novo : Imovel
{
    public float precoTaxa { get; set; }
    public float totalNovo()
    {
        return (preco + precoTaxa);
    }

    public Novo(string endereco, float preco, float precoTaxa) : base(endereco, precoTaxa)
    {
        this.endereco = endereco;
        this.preco = preco;
        this.precoTaxa = precoTaxa;
    }
}

public class Velho : Imovel
{
    public float precoTaxa { get; set; }
    public float totalVelho()
    {
        return (preco - precoTaxa);
    }

    public Velho(string endereco, float preco, float precoTaxa) : base(endereco, precoTaxa)
    {
        this.endereco = endereco;
        this.preco = preco;
        this.precoTaxa = precoTaxa;
    }
}

class Program
{
    static void Main(string[] args)
    {   
        // NOVO IMOVEL
        Novo novoImovel = new Novo("Rua Oswaldo Cruz, 277", 2000000, 500000);
        Console.WriteLine("O valor do imóvel, é: R${0:C}", novoImovel.preco);
        Console.WriteLine("O valor da taxa, é: R${0:C}", novoImovel.precoTaxa);
        Console.WriteLine("O valor total, é: R${0:C}", novoImovel.totalNovo());

        Console.WriteLine("");

        // VELHO IMOVEL
        Velho velhoImovel = new Velho("Rua Cesário Mota, 8", 1000000, 250000);
        Console.WriteLine("O valor do imóvel, é: R${0:C}", velhoImovel.preco);
        Console.WriteLine("O valor da taxa, é: R${0:C}", velhoImovel.precoTaxa);
        Console.WriteLine("O valor total, é: R${0:C}", velhoImovel.totalVelho());
    }
}

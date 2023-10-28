///////////////////////////////////////////// EXERCICIO 1
// O EXERCÍCIO FICOU UM POUCO CONFUSO, ENTAO FLEXIBILIZEI ALGUMAS COISAS, CONFORME DITO EM AULA.
// COMO POR EXEMPLO, MÉTODOS QUE FORAM PEDIDOS MAS POR UTILIZAR PROPRIEDADE HAVIA O "GET", ENTAO NÃO ACHEI NECESSÁRIO.

//public class Ingresso
//{
//    public float preco { get; set; }
//    public Ingresso (float preco)
//    {
//        this.preco = preco;
//        Console.WriteLine("- Preço: R$ {0:C}", this.preco);
//    }
//}

//public class VIP : Ingresso
//{
//    public float taxaVIP { get; set; } = 50;
//    public float valorTotal() { return this.preco + this.taxaVIP; }
//    public VIP(float preco) : base(preco)
//    {
//        this.preco = preco;
//        Console.WriteLine("- Taxa VIP: R$ {0:C}", this.taxaVIP);
        
//    }
//}

//public class Normal : Ingresso
//{
//    public float taxaNormal { get; set; }

//    public float valorTotal() { return this.preco + this.taxaNormal; }
//    public Normal(float preco, float taxaNormal) : base(preco)
//    {
//        this.preco = preco;
//        this.taxaNormal = taxaNormal;

//        Console.WriteLine("- Taxa NORMAL: R$ {0:C}", this.taxaNormal);
//        Console.WriteLine("-- Total: R$ {0:C}", this.valorTotal());
//    }
//}

//public class Camarote_Inferior : VIP
//{
//    public string localidade { get; set; } = "Portão A";
//    public Camarote_Inferior(float preco) : base(preco)
//    {
//        this.preco = preco;

//        Console.WriteLine("- Taxa CAMAROTE INFERIOR: R$ 0");
//        Console.WriteLine("- Localidade: {0}", this.localidade);
//    }
//}

//public class Camarote_Superior : VIP
//{
//    public string localidade { get; set; } = "Portão B";
//    public float taxaCamarote = 100;
//    public float valorTotalSuperior() { return this.preco + this.taxaVIP + this.taxaCamarote; }
//    public Camarote_Superior(float preco) : base(preco)
//    {
//        this.preco = preco;

//        Console.WriteLine("- Taxa CAMAROTE SUPERIOR: R$ {0:C}", this.taxaCamarote);
//        Console.WriteLine("- Localidade: {0}", this.localidade);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    { 
//        // INGRESSO NORMAL
//        Console.WriteLine("O ingresso NORMAL foi emitido!");
//        Normal ingressoNormal = new Normal(25, 25);
//        Console.WriteLine("");

//        // INGRESSO VIP
//        Console.WriteLine("O ingresso VIP foi emitido!");
//        VIP ingressoVIP = new VIP(25);
//        Console.WriteLine("-- Total: R$ {0:C}", ingressoVIP.valorTotal());
//        Console.WriteLine("");        

//        // INGRESSO VIP - CAMAROTE INFERIOR
//        Console.WriteLine("O ingresso VIP - CAMAROTE INFERIOR foi emitido!");
//        Camarote_Inferior ingressoCI = new Camarote_Inferior(200);
//        Console.WriteLine("-- Total: R$ {0:C}", ingressoCI.valorTotal());
//        Console.WriteLine("");

//        // INGRESSO VIP - CAMAROTE SUPERIOR
//        Console.WriteLine("O ingresso VIP - CAMAROTE SUPERIOR foi emitido!");
//        Camarote_Superior ingressoCS = new Camarote_Superior(300);
//        Console.WriteLine("-- Total: R$ {0:C}", ingressoCS.valorTotalSuperior());
//        Console.WriteLine("");
//    }
//}


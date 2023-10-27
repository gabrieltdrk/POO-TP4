public class Ingresso
{
    float preco { get; set; }

    public float imprimeValor()
    {
        return this.preco;
    }

public class VIP : Ingresso
{
    float taxaVIP { get; set; } = 0;
    public float imprimeValorVIP()
    {
        return imprimeValor() + taxaVIP;
    }

    public class Normal : Ingresso
    {
        float taxaNormal { get; set; } = 0;
        public float imprimeValorNormal()
        {
            return imprimeValor() + taxaNormal;
        }
    }


    public class Camarote_Inferior : VIP
    {
        string localidade { get; } = "Inferior";
    }
    public class Camarote_Superior : VIP
    {
        string localidade { get; } = "Superior";
    }
    class Program
    {
            static void Main(string[] args)
            {
                // INGRESSO VIP
                
        }
    }
}


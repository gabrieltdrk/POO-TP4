class Ingresso
{
    float preco { get; set; }

    public float imprimeValor()
    {
        return this.preco;
    }

}

class Camarote_Inferior : Ingresso
{
    string localidade { get; set; }
}
class Camarote_Superior : Ingresso
{

}

class Normal : Ingresso
{

}

class VIP : Ingresso
{
    float adicionalVIP = 25;
}
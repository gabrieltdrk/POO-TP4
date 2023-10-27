<h1 align="center"> 🧑‍💻 Programação Orientada a Objetos <br> Trabalho Prático #4</h1>

<img align="center" src="https://fenestra.com.br/wp-content/uploads/2021/03/POO.jpg">

## 🔍 Aula 4 - Herança

Em C#, a herança é um dos pilares da programação orientada a objetos. Ela permite que uma classe (chamada classe derivada) herde características (métodos e campos) de outra classe (chamada classe base). Isso promove a reutilização de código e a criação de uma hierarquia de classes.:

- Classe Base: A classe da qual outra classe herda membros. Essa classe é muitas vezes chamada de classe pai ou superclasse.

- Classe Derivada: A classe que herda membros de outra classe. Também é chamada de classe filha ou subclasse.

- Herança direta: A herança direta ocorre quando uma classe herda de outra classe. Nesse caso, a classe derivada (subclasse) estende a classe base (superclasse). A herança direta é um conceito fundamental em programação orientada a objetos.

- Herança transitiva: A herança transitiva ocorre quando uma classe herda características de uma classe não diretamente, mas por meio de uma ou mais classes intermediárias. Isso significa que uma classe derivada herda propriedades e métodos de uma classe base por meio de uma cadeia de herança.


### ⚒️ Exercícios da Aula:

1- Crie uma classe chamada Ingresso que possui um
valor em reais e um método imprimeValor(). crie
uma classe VIP, que herda Ingresso e possui um
valor adicional. Crie um método que retorne o valor
do ingresso VIP (com o adicional incluído). Crie uma
classe Normal, que herda Ingresso e possui um
método que imprime: "Ingresso Normal". Crie uma
classe CamaroteInferior (que possui a localização
do ingresso e métodos para acessar e imprimir esta
localização) e uma classe CamaroteSuperior, que é
mais cara (possui valor adicional). Esta última possui
um método para retornar o valor do ingresso.
Ambas as classes herdam a classe VIP.


2- Crie a classe Imovel, que possui um endereço e um
preço. Crie uma classe Novo, que herda Imovel e
possui um adicional no preço. Crie métodos de
acesso e impressão deste valor adicional. Crie uma
classe Velho, que herda Imovel e possui um
desconto no preço. Crie métodos de acesso e
impressão para este desconto

<div align="center">Coded by <a href="https://github.com/gabrieltdrk">gabrieltdrk</a>.</div>
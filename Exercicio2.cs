using System;

public class Item
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome} Valor: {Preco:C}");
    }
}

public class Pedido
{
    public int NumeroDoPedido { get; set; }


    public List<Item> Itens { get; set; }

    public Pedido()
    {
        Itens = new List<Item>();
    }

    public void AdicionarItem(Item item)
    {
        Itens.Add(item);
    }

    public void FecharPedido()
    {
        double total = 0;

      
        foreach (var item in Itens)
        {
            item.ExibirDetalhes();
            total += item.Preco;
        }

        Console.WriteLine($"Total do pedido: {total:C}");
    }
}

class Program
{
    static void Main()
    {
        Pedido meuPedido = new Pedido { NumeroDoPedido = 1001 };

        meuPedido.AdicionarItem(new Item { Nome = "Teclado", Preco = 20.00 });
        meuPedido.AdicionarItem(new Item { Nome = "Mouse", Preco = 25.00 });
        meuPedido.AdicionarItem(new Item { Nome = "Monitor", Preco = 100.00 });

        meuPedido.FecharPedido();
    }
}

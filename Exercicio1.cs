using System;
public class Animal
{
    public string Nome;
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}
public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Auau");
    }
}
public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau");
    }
}
class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal { Nome = "Animal" };
        Console.Write($"{animalGenerico.Nome} faz:");
        animalGenerico.EmitirSom();
        Cachorro Rex = new Cachorro { Nome = "Rex" };
        Console.Write($"{Rex.Nome} faz:");
        Rex.EmitirSom();
        Gato Frajola = new Gato { Nome = "Frajola" };
        Console.Write($"{Frajola.Nome} faz:");
        Frajola.EmitirSom();
    }
}

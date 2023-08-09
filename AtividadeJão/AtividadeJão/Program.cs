public interface IAnimal
{
    void EmitirSom();
}
public class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}
public class Gato : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("O gato mia");
    }
}
class program
{
    static void Main(string[] args)
    {
        IAnimal cachorro = new Cachorro();
        IAnimal gato = new Gato();

        cachorro.EmitirSom();
        gato.EmitirSom();

        Console.ReadLine();
    }
}

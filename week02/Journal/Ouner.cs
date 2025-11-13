using System.IO;

public class Owner
{
    public String _name = "";
    public String _fileName = "";

    public void RegisterOwner()
    {
        Console.WriteLine("What is your name?");
        _name = Console.ReadLine();
        
        Console.WriteLine("What is your Journal name?");
        _fileName = Console.ReadLine();

    }
}
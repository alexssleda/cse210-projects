using System.IO;

public class Journal
{
    public String _fileName = "";
    public List<String> _lines = new List<String>();

    public void SaveFile()
    {

        Console.WriteLine("What is the file name?");
        _fileName = Console.ReadLine();

        if (!_fileName.EndsWith(".txt"))
        {
            _fileName += ".txt";
        }
        using (StreamWriter OutputFile = new StreamWriter(_fileName))
        {
            foreach (String line in _lines)
            {
                OutputFile.WriteLine(line);
            }
        }

    }

    public void LoadFile()
    {
        _fileName = owner._fileName;
        _lines.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (String line in lines)
        {
            _lines.Add(line);
        }
    }
}
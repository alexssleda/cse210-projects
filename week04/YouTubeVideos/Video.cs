class Video
{
    public String _title = "";
    public String _author = "";
    public int _length = 0;

    public List<Comment> _comments = new List<Comment>();

    public void ShowComments()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        foreach (Comment j in _comments)
        {
            Console.WriteLine($"Name: {j._name}");
            Console.WriteLine($"Comment: {j._comment}");
        }
        Console.WriteLine("");
    }

}
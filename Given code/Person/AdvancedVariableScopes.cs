Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald");
book.PrintSummary();

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"\"{Title}\" is written by {Author}.";
        Console.WriteLine(summary);
    }

    public int GetTitleLengthWithoutWhitespaces()
    {
        string titleWithoutSpaces = Title.Replace(" ", "");
        return titleWithoutSpaces.Length;
    }
}
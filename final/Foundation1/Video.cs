public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Video(string title, string author, int length, List<Comments> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public Video() { }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAutor()
    {
        return _author;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }
    public void SetComments(List<Comments> comments)
    {
        _comments = comments;
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
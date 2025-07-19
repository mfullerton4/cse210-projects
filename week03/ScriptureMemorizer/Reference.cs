public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string referenceText)
    {
        string[] bookAndRest = referenceText.Split(' ');
        _book = bookAndRest[0];

        string[] chapterVerse = bookAndRest[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse[1].Contains("-"))
        {
            string[] verses = chapterVerse[1].Split('-');
            _startVerse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
            _startVerse = int.Parse(chapterVerse[1]);
            _endVerse = null;
        }
    }

    // Getters
    public string GetBook() => _book;
    public int GetBookChapter() => _chapter;
    public int GetStartVerse() => _startVerse;
    public int GetEndVerse() => _chapter;

    // Setters
    public void SetBook(string book) => _book = book;
    public void SetChapter(int chapter) => _chapter = chapter;
    public void SetStartVerse(int startVerse) => _startVerse = startVerse;
    public void SetEndVerse(int? endVerse) => _endVerse = endVerse;

    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }

}
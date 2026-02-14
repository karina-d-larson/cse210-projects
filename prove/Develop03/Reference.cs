class Reference
{
    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string book, int chapter, string verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verses}";
    }
}

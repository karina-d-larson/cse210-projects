class Word
{
    private string _text;
    private bool _visible;
    private bool _canHide;

    public Word(string text, bool canHide = true)
    {
        _text = text;
        _visible = true;
        _canHide = canHide;
    }

    public void Hide()
    {
        if (_canHide)
        {
            _visible = false;
        }
    }

    public string GetDisplay()
    {
        return _visible ? _text : "_____";
    }

    public bool IsVisible()
    {
        return _visible;
    }

    public bool CanHide()
    {
        return _canHide;
    }
}

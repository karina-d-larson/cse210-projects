public class Job
{
    // attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // behavior
    public void Display()
    {
        string result;
        result = $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
        Console.WriteLine(result);
    }
}
public class Entry
{
    public string _date = DateTime.Today.ToString("MM-dd-yyyy");
    public string _prompt = Prompt.RandomPrompt("prompts.txt");
    public string _response;
}
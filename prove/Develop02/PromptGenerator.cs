public class PromptGenerator 
{
    public List<string> _prompts;

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}
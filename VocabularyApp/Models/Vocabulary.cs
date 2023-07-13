namespace VocabularyApp.Controllers;

public class Vocabulary
{
    public int Id { get; set; }
    public string Word { get; set; }
    public string Definition { get; set; }
    public string Usage { get; set; }
    public string RelatedWords { get; set; }
    public Vocabulary()
    {
        
    }
}
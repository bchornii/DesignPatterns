namespace _02_ChainOfResponsibility_Document
{
    public interface IEditor
    {
        ReviewResult ReviewDocument(Document document);
    }
}

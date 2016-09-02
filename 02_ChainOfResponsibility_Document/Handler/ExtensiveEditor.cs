namespace _02_ChainOfResponsibility_Document
{
    public class ExtensiveEditor : IEditor
    {
        public ReviewResult ReviewDocument(Document document)
        {
            ReviewResult result = new ReviewResult
            {
                Reviewer = GetType().Name,
                Approved = true
            };            
            return result;
        }
    }
}

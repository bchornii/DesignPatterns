namespace _02_ChainOfResponsibility_Document
{
    public class SimpleEditor : IEditor
    {
        public IEditor Successor { get; private set; }
        public SimpleEditor(IEditor successor)
        {
            Successor = successor;
        }
        public ReviewResult ReviewDocument(Document document)
        {
            ReviewResult result = new ReviewResult
            {
                Reviewer = GetType().Name
            };

            if (!string.IsNullOrWhiteSpace(document.Content))
            {
                if (document.Content.Length > 1000)
                {
                    return Successor.ReviewDocument(document);
                }
                else if (document.Content.Length > 600)
                {
                    result.Approved = true;
                }
                else
                {
                    result.Approved = false;
                }
            }
            return result;
        }
    }
}

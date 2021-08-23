namespace DocPrintManager.ViewModels
{
    public class DocumentItemViewModel
    {
        public DocumentItemViewModel(DocumentTypeViewModel type, string docName)
        {
            Type = type;
            DocName = docName;
        }
        public string DocName { get; set; }
        public DocumentTypeViewModel Type { get; set; }
        public bool? Printed { get; set; } = false;
    }
}

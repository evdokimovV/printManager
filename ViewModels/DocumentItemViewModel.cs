namespace DocPrintManager.ViewModels
{
    internal class DocumentItemViewModel
    {
        internal DocumentItemViewModel(DocumentTypeViewModel type, string docName)
        {
            Type = type;
            DocName = docName;
        }
        internal string DocName { get; set; }
        internal DocumentTypeViewModel Type { get; set; }
        internal bool? Printed { get; set; } = false;
    }
}

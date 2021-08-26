using DocPrintManager.Basics;

namespace DocPrintManager.ViewModels
{
    internal class DocumentGridItem : BaseViewModel
    {
        private bool? _printed;

        internal DocumentGridItem(DocumentItemViewModel doc, int id)
        {
            Id = id;
            Type = doc.Type;
            Printed = doc.Printed;
            DocName = doc.DocName;
        }

        internal bool? Printed
        {
            get => _printed;
            set
            {
                _printed = value;
                OnPropertyChanged();
            }
        }
        internal DocumentTypeViewModel Type { get; set; }
        public string Status => Printed.HasValue 
            ? Printed.Value 
                ? PrintManagerConstants.DocStatusPrinted 
                : PrintManagerConstants.DocStatusQueue
            : PrintManagerConstants.DocStatucCancelled;
        public string TypeName => Type.Name;
        public int PrintTime => Type.PrintTime;
        public string ListSize => Type.ListSize;
        public string DocName { get; set; }
    }
}

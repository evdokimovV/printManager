using DocPrintManager.Basics;

namespace DocPrintManager.ViewModels
{
    public class DocumentGridItem : BaseViewModel
    {
        private bool? _printed;

        public DocumentGridItem(DocumentItemViewModel doc, int id)
        {
            Id = id;
            Type = doc.Type;
            Printed = doc.Printed;
            DocName = doc.DocName;
        }

        public bool? Printed
        {
            get => _printed;
            set
            {
                _printed = value;
                OnPropertyChanged();
            }
        }
        public int Id { get; set; }
        public DocumentTypeViewModel Type { get; set; }
        public string Status => Printed.HasValue 
            ? Printed.Value 
                ? "Напечатан" 
                : "В очереди" 
            : "Отменен";
        public string TypeName => Type.Name;
        public int PrintTime => Type.PrintTime;
        public string ListSize => Type.ListSize;
        public string DocName { get; set; }
    }
}

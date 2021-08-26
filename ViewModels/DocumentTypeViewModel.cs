using System.ComponentModel;
using System.Runtime.CompilerServices;
using DocPrintManager.Basics;

namespace DocPrintManager.ViewModels
{
    internal class DocumentTypeViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private bool _isChecked;

        protected internal DocumentTypeViewModel(int id, string name, int printTime, string listSize) : base(id, name)
        {
            PrintTime = printTime;
            ListSize = listSize;
        }
        internal int PrintTime { get; set; }
        internal string ListSize { get; set; }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }
    }
}

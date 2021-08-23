using System.ComponentModel;
using System.Runtime.CompilerServices;
using DocPrintManager.Basics;

namespace DocPrintManager.ViewModels
{
    public class DocumentTypeViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private bool _isChecked;

        protected internal DocumentTypeViewModel(int id, string name, int printTime, string listSize) : base(id, name)
        {
            PrintTime = printTime;
            ListSize = listSize;
        }
        public int PrintTime { get; set; }
        public string ListSize { get; set; }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

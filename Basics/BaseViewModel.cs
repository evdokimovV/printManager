using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DocPrintManager.Basics
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        protected BaseViewModel()
        {
        }

        internal int Id { get; set; }
        internal string Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

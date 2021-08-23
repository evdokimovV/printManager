using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DocPrintManager.Basics
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        protected BaseViewModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

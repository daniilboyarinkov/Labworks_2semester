using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabWork5.Components
{

    public class Subject : INotifyPropertyChanged
    {
        private string? _name;
        public string? Name
        {
            get => _name;
            set { _name = value; NotifyPropertyChanged("Name"); }
        }
        private bool _isDone;
        public bool IsDone
        {
            get => _isDone;
            set { _isDone = value; NotifyPropertyChanged("IsDone"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

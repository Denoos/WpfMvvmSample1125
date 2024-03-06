using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfMvvmSample.ViewModel
{
    public class BaseVM : INotifyPropertyChanged
    {
        protected void Signal([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

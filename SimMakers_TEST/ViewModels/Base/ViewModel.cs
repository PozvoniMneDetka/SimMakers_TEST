using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimMakers_TEST.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string _propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string _propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(_propertyName);
            return true;
        }
    }
}

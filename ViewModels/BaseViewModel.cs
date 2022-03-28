using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LightCrm.ViewModels
{

    /// <summary>
    /// Базовый класс для всех ViewModels
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Изменение значения поля
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

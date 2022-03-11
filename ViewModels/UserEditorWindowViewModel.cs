using LightCrm.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна редактирования пользователей
    /// </summary>
    public class UserEditorWindowViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        private IEnumerable<UserDto> _userData;
        private ICommand _buttonCreateClickCommand;
        private ICommand _buttonEditeClickCommand;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<UserDto> UserData
        {
            get => _userData;
            set
            {
                _userData = value;
                //OnPropertyChanged();
            }
        }

        public UserEditorWindowViewModel(string name, UserDto user)
        {
            Name = name;
            //GetUserData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }
    }
}

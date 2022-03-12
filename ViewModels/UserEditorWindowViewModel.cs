using LightCrm.Commands;
using LightCrm.ServiceReference;
using System.Windows;
using System.Windows.Input;
using LightCrm.Views;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления окна редактирования пользователей
    /// </summary>
    public class UserEditorWindowViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        private UserDto _user;
        private ICommand _buttonOkClickCommand;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public UserDto User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }

        public UserEditorWindowViewModel(string name, UserDto user)
        {
            Name = name;
            User = user;
            if (user==null)
            {                
                return;
            }


            //GetUserData();
            //_dataBaseReadCommand = new RelayCommand(DataBaseRead);
        }

        public ICommand ButtonOkClickCommand
        {
            get
            {
                if (_buttonOkClickCommand == null)
                {
                    _buttonOkClickCommand = new RelayCommand(
                        p => ButtonOkClick());
                }

                return _buttonOkClickCommand;
            }
        }

        public void ButtonOkClick(UserDto user = null)
        {
            MessageBox.Show("Ok");
        }
    }
}

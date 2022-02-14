namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления страницы работы с пользователями
    /// </summary>
    public class UsersAdministrationViewModel : BaseViewModel, IPageViewModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public UsersAdministrationViewModel()
        {
            Name = "Пользователи";
        }
    }
}

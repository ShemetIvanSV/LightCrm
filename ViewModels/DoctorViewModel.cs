namespace LightCrm.ViewModels
{
    public class DoctorsViewModel : BaseViewModel, IPageViewModel
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

        public DoctorsViewModel()
        {
            Name = "Врачи";
        }
    }
}
namespace LightCrm.ViewModels
{
    public class PatientsViewModel : BaseViewModel, IPageViewModel
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

        public PatientsViewModel()
        {
            Name = "Пациенты";
        }
    }
}

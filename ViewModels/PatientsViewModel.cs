using LightCrm.Commands;

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


        private RelayCommand _savePatient;
        public RelayCommand SavePatient;

        private RelayCommand _changePatient;
        public RelayCommand ChangePatient;

        private RelayCommand _deletePatient;
        public RelayCommand DeletePatient;

        public PatientsViewModel()
        {
            Name = "Запись пациентов";
        }
    }
}

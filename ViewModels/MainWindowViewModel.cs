using LightCrm.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    /// <summary>
    /// Модель представления главного окна, 
    /// включает в себя так же логику перемещения между страницами
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        private ICommand _changePageCommand;
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        //Передаём пользователя через конструктор
        public MainWindowViewModel()
        {
            // Здесь будет логика того - какие окна отображать конкретному пользователю
            PageViewModels.Add(new UsersAdministrationViewModel());
            PageViewModels.Add(new PatientsViewModel());
            PageViewModels.Add(new UsersOrdersViewModel());
            PageViewModels.Add(new TimeTableViewModel());
            PageViewModels.Add(new RegistrationViewModel());
            CurrentPageViewModel = PageViewModels[0];
        }

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged();
                }
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
    }
}

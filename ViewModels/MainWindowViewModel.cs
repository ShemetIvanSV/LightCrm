using LightCrm.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LightCrm.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentPage;
        private readonly ICommand _fooExecuteCommand;

        public BaseViewModel CurrentPage
        {
            get => _currentPage;
            set 
            { 
                _currentPage = value; 
                OnPropertyChanged(); 
            }
        }

        public ICommand FooExecuteCommand
        {
            get => _fooExecuteCommand;
        }

        public MainWindowViewModel()
        {
            _fooExecuteCommand = new RelayCommand(FooExecute);
        }

        private void FooExecute(object obj = null)
        {
            //TODO: Использование сервисов для выполнения бизнес логики
        }

        //TODO: Команды для выбора страницы
    }
}

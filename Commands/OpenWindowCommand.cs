using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LightCrm.Commands
{
    public class OpenWindowCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            TypeInfo p = (TypeInfo)parameter;

            return p.BaseType == typeof(Window);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (parameter == null)
                throw new ArgumentNullException("TargetWindowType");

            //Get the type.
            TypeInfo p = (TypeInfo)parameter;
            

            //Make sure the parameter passed in is a window.
            if (p.BaseType != typeof(Window))
                throw new InvalidOperationException("parameter is not a Window type");

            //Create the window.
            Window wnd = Activator.CreateInstance(p) as Window;

            OpenWindow(wnd);
        }

        protected virtual void OpenWindow(Window wnd)
        {
            wnd.Show();
        }
    }
}


using ICommand.Models;
using ICommand.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ViewModels.Commands
{
    public class SimpleCommand : System.Windows.Input.ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ViewModelBase ViewModel { get; set; }

        public SimpleCommand(ViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {

                var language = parameter as string;

                if(language != null && language.Contains("JAVA"))
                {
                    return false;
                }


            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Hello ");
            //ViewModel.SimpleMethod();
        }
    }
}

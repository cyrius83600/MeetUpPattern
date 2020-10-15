using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.Commands;

namespace ICommand.ViewModels
{
    public class ViewModelBase
    {
        public SimpleCommand simpleCommand { get; set; }

        public ViewModelBase()
        {
            this.simpleCommand = new SimpleCommand(this);
        }

        public void SimpleMethod()
        {
            MessageBox.Show("Hello ");
        }
    }
}

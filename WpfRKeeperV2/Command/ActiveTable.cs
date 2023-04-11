using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfRKeeperV2.Command;
using WpfRKeeperV2.Models;
using WpfRKeeperV2.Views;

namespace WpfRKeeperV2.Command
{
    internal class ActiveTable : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}

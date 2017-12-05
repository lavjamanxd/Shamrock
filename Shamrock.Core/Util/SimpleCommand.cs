using System;
using System.Windows.Input;

namespace Shamrock.Core.Util
{
    public class SimpleCommand : ICommand
    {
        private readonly Action _actionToInvoke;

        public SimpleCommand(Action actionToInvoke)
        {
            _actionToInvoke = actionToInvoke;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _actionToInvoke.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}
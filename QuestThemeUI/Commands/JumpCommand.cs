using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuestThemeUI.Commands
{
    public class JumpCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private bool needResult = false;

        private Action _action;

        public JumpCommand(Action execute)
        {
            _action = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }

    public class JumpCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private bool needResult = false;

        private Action<T> _action;

        public JumpCommand(Action<T> execute)
        {
            _action = execute;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            T t = default(T);

            if (parameter != null)
            {
                t = (T)parameter;
            }

            _action(t);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace YMM4_Test_Plugin
{
    internal class BaseCommand : ICommand{
        private readonly Action<object>? action = null;
        private readonly Action? actionNoParam = null;

        public BaseCommand(Action action)
        {
            actionNoParam = action;
        }

        public BaseCommand(Action<object?> action)
        {
            this.action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (action != null)
            {
                if (parameter is object value)
                {
                    action(value);
                }
            }
            else if (actionNoParam != null)
            {
                actionNoParam();
            }
        }
    }
}

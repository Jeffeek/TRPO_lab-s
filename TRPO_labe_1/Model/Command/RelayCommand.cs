﻿using System;

namespace TRPO_labe_1.Model.Command
{
    public class RelayCommand : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentException(nameof(execute));
            _canExecute = canExecute;
        }

        public override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _execute(parameter);
    }
}
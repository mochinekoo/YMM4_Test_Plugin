using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace YMM4_Test_Plugin
{
    internal class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonCommand ButtonCommand { get; private set; }

        public TestViewModel() { 
            ButtonCommand = new ButtonCommand(this);
        }
    }
}

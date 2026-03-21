using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using YukkuriMovieMaker.ViewModels;

namespace YMM4_Test_Plugin
{
    internal class ButtonCommand
    {

        private readonly TestViewModel testViewModel_;

        public ICommand TestCommand { get; private set; }

        public ButtonCommand(TestViewModel testViewModel)
        {
            testViewModel_ = testViewModel;
            TestCommand = new BaseCommand(RunTestCommand);
        }

        private void RunTestCommand()
        {
            MessageBox.Show("あああ", "タイトル", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using YukkuriMovieMaker.Plugin;

namespace YMM4_Test_Plugin {
    internal class Main : IToolPlugin{
        public string Name => "TestPlugin";

        public Type ViewModelType => typeof(TestViewModel);

        public Type ViewType => typeof(TestWindow);

        public Main() {
            MessageBox.Show("あああ", "タイトル", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
    }
}

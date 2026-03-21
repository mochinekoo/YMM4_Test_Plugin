using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using YukkuriMovieMaker.Plugin;

namespace YMM4_Test_Plugin {
    internal class Main : IPlugin {
        public string Name => "TestPlugin";

        public Main() {
            MessageBox.Show("あああ", "タイトル", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
    }
}

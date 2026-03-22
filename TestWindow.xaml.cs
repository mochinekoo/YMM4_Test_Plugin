using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YukkuriMovieMaker.Commons;
using YukkuriMovieMaker.Settings;

namespace YMM4_Test_Plugin
{
    /// <summary>
    /// TestWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class TestWindow : UserControl, IPropertyEditorControl
    {
        public TestWindow()
        {
            InitializeComponent();

            foreach(var item in ItemSettings.Default.SortedTemplates) {
                Button button = new Button();
                button.Content = item.Name + "\n" + item.GetType();
                TemplateWrap.Children.Add(button);
            }
            
        }

        public event EventHandler? BeginEdit;
        public event EventHandler? EndEdit;

        public IEditorInfo Editor;

        public void SetEditorInfo(IEditorInfo info)
        {
            Editor = info;
        }
    }
}

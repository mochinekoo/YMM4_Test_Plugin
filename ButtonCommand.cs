using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using YukkuriMovieMaker.Project.Items;
using YukkuriMovieMaker.ViewModels;

namespace YMM4_Test_Plugin
{
    internal class ButtonCommand
    {

        private readonly TestViewModel testViewModel_;

        public ICommand TestCommand { get; private set; }
        public ICommand TemplateButtonCommand {  get; private set; }

        public ButtonCommand(TestViewModel testViewModel)
        {
            testViewModel_ = testViewModel;
            TestCommand = new BaseCommand(RunTestCommand);
            TemplateButtonCommand = new BaseCommand(param => { RunTemplateButtonCommand((IItem[])param!); });
        }

        private void RunTestCommand()
        {
            //MessageBox.Show("あああ", "タイトル", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            var timelineToolInfo = Util.GetInstacne().GetTimelineToolInfo();
            var timeline = timelineToolInfo.Timeline;
            var selectedItem = timeline.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("何も選択されてません", "たいとる", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Type type = selectedItem.GetType();
                string messageBoxText = type.Name;
                MessageBox.Show(messageBoxText, "タイトル", MessageBoxButton.OK, MessageBoxImage.Question);
            }

        }

        private void RunTemplateButtonCommand(IItem[] items)
        {
            var current = Util.GetInstacne().GetTimelineToolInfo().Timeline.CurrentFrame;
            IEnumerable<int> layer = Util.GetInstacne().GetTimelineToolInfo().Timeline.LayerSelection.GetSelectedLayers();
            Util.GetInstacne().GetTimelineToolInfo().Timeline.TryAddItems(items, current, layer.Count() == 0 ? 0 : layer.ElementAt(0));
        }
    }
}

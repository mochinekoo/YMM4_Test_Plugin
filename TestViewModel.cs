using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using YukkuriMovieMaker.Plugin;
using YukkuriMovieMaker.Settings;
using YukkuriMovieMaker.Views;

namespace YMM4_Test_Plugin
{
    internal class TestViewModel : INotifyPropertyChanged, ITimelineToolViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private TimelineToolInfo toolInfo_;

        public ButtonCommand ButtonCommand { get; private set; }

        public TestViewModel() { 
            ButtonCommand = new ButtonCommand(this);
            TemplateText = string.Join(",", ItemSettings.Default.SortedTemplates.Select(t => t.Name));
        }

        private string templateText_ = "";
        public string TemplateText {
            get { return templateText_; }
            set {
                templateText_ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TemplateText)));
            }
        }

        public void SetTimelineToolInfo(TimelineToolInfo info)
        {
            toolInfo_ = info;
        }

        public TimelineToolInfo GetTimelineToolInfo()
        {
            return toolInfo_;
        }
    }
}

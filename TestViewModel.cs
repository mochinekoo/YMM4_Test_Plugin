using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using YukkuriMovieMaker.Plugin;

namespace YMM4_Test_Plugin
{
    internal class TestViewModel : INotifyPropertyChanged, ITimelineToolViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private TimelineToolInfo toolInfo_;

        public ButtonCommand ButtonCommand { get; private set; }

        public TestViewModel() { 
            ButtonCommand = new ButtonCommand(this);
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

using System;
using System.Collections.Generic;
using System.Text;
using YukkuriMovieMaker.Plugin;

namespace YMM4_Test_Plugin
{
    internal class Util : ITimelineToolViewModel
    {
        private static Util? util = null;
        private TimelineToolInfo? toolInfo_;

        public static Util GetInstacne()
        {
            if (util == null)
            {
                util = new Util();
            }
            return util;
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

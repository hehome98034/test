using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AllImportantProjects
{
    class ScheduleQueue
    {
        public int start;
        public int end;
    }

    class MergeSchedule
    {
        public MergeSchedule()
        {

        }

        public void doMerge (ScheduleQueue[] my, ArrayList result)
        {
            int curStart=0;
            int curEnd = 0;
            if ((my == null) || (my.Length == 0)) return;
            ScheduleQueue cur = null;
            for (int i = 0; i<my.Length; i++)
            {                
                if (i==0)
                {
                    cur = new ScheduleQueue();
                    cur.start = my[0].start;
                    curStart = cur.start;
                    curEnd = my[0].end;
                }
                else if (my[i].start > curEnd)
                {
                    cur.end = curEnd;
                    result.Add(cur);
                    cur = new ScheduleQueue();
                    cur.start = my[i].start;
                    curStart = cur.start;
                    curEnd = my[i].end;
                }

                else if (my[i].end <= curEnd)
                {
                    ///do nothing
                }

                else if (my[i].end > curEnd)
                {
                    curEnd = my[i].end;
                }
            }

            if (cur != null)
            {
                cur.end = curEnd;
                result.Add(cur);
            }
        }
    }
}

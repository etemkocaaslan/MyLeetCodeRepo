namespace leetcode.Solutions
{
    public class Solution1235
    {
        public class WorkInterval
        {
            public int StartTime, EndTime, Profit;
            public WorkInterval(int start, int end, int profit)
            {
                StartTime = start;
                EndTime = end;
                Profit = profit;
            }
        }

        public int JobScheduling(int[] startTimes, int[] endTimes, int[] profits)
        {
            int jobCount = startTimes.Length;
            WorkInterval[] intervals = new WorkInterval[jobCount];
            for (int i = 0; i < jobCount; i++)
                intervals[i] = new WorkInterval(startTimes[i], endTimes[i], profits[i]);

            Array.Sort(intervals, (a, b) => a.EndTime.CompareTo(b.EndTime));

            int[] maxProfitUpToJob = new int[jobCount];
            maxProfitUpToJob[0] = intervals[0].Profit;

            for (int currentJob = 1; currentJob < jobCount; currentJob++)
            {
                int profitIncludingCurrent = intervals[currentJob].Profit;
                int lastIndex = -1;
                for (int j = currentJob - 1; j >= 0; j--)
                {
                    if (intervals[j].EndTime <= intervals[currentJob].StartTime)
                    {
                        lastIndex = j;
                        break;
                    }
                }

                if (lastIndex != -1)
                {
                    profitIncludingCurrent += maxProfitUpToJob[lastIndex];
                }

                int profitExcludingCurrent = maxProfitUpToJob[currentJob - 1];

                maxProfitUpToJob[currentJob] = Math.Max(profitIncludingCurrent, profitExcludingCurrent);
            }

            return maxProfitUpToJob[jobCount - 1];
        }
    }
}

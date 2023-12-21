using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Solution815
    {
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
                return 0;

            Dictionary<int, List<int>> stopToBuses = new Dictionary<int, List<int>>();

            for (int i = 0; i < routes.Length; i++)
            {
                foreach (int stop in routes[i])
                {
                    if (!stopToBuses.ContainsKey(stop))
                        stopToBuses[stop] = new List<int>();

                    stopToBuses[stop].Add(i);
                }
            }

            Queue<int> stopsQueue = new Queue<int>();
            HashSet<int> exploredStops = new HashSet<int>();
            HashSet<int> exploredRoutes = new HashSet<int>();

            stopsQueue.Enqueue(source);
            exploredStops.Add(source);

            int numBuses = 0;

            while (stopsQueue.Count > 0)
            {
                int stopsToExplore = stopsQueue.Count;

                for (int i = 0; i < stopsToExplore; i++)
                {
                    int currentExploringStop = stopsQueue.Dequeue();
                    List<int> busesAtCurrentStop = stopToBuses.ContainsKey(currentExploringStop) ? stopToBuses[currentExploringStop] : new List<int>();

                    foreach (int busAtCurrentStop in busesAtCurrentStop)
                    {
                        if (exploredRoutes.Contains(busAtCurrentStop))
                            continue;

                        exploredRoutes.Add(busAtCurrentStop);

                        foreach (int nextExploringStop in routes[busAtCurrentStop])
                        {
                            if (exploredStops.Contains(nextExploringStop))
                                continue;

                            exploredStops.Add(nextExploringStop);

                            if (nextExploringStop == target)
                                return numBuses + 1;

                            stopsQueue.Enqueue(nextExploringStop);
                        }
                    }
                }
                numBuses++;
            }

            return -1;
        }
    }
}

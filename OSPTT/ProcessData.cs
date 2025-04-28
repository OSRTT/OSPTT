using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSPTT
{
    public class ProcessData
    {
        /////////////////////////////////////////////////////////////////////////////
        //              Input Lag
        ////////////////////////////////////////////////////////////////////////////


        public class rawInputLagResult
        {
            public resultType ResultType { get; set; }
            public double ClickTime { get; set; }
            public float FrameTime { get; set; }
            public int TimeTaken { get; set; }
            public int SampleCount { get; set; }
            public double SampleTime { get; set; }
            public List<int> Samples { get; set; }
        }

        public enum resultType
        {
            KeyboardActuation,
            KeyboardForce,
            KeyboardLatency,
            MouseClick,
            MouseSensor,
        }

        public class inputLagResult
        {
            public resultType Type { get; set; }
            public int shotNumber { get; set; }
            public double clickTimeMs { get; set; }
            public double SetActuationPoint { get; set; }
            public double ActuationPoint { get; set; }
            public int SwitchForce { get; set; }
            public double PreTravelDistance { get; set; }
            public double SensorDistance { get; set; }
            public List<double> latencyResults { get; set; }


            public double frameTimeMs { get; set; }
            public double inputLag { get; set; }
            public double totalInputLag { get; set; }
            public double onDisplayLatency { get; set; }
        }

        public class averageInputLagResult
        {
            public double AVG { get; set; }
            public double MIN { get; set; }
            public double MAX { get; set; }
        }

        public class averagedInputLag
        {
            public List<inputLagResult> inputLagResults { get; set; }
            public averageInputLagResult ClickTime { get; set; }
            public averageInputLagResult FrameTime { get; set; }
            public averageInputLagResult onDisplayLatency { get; set; }
            public averageInputLagResult totalInputLag { get; set; }
            public string RunName { get; set; }
        }

            

        

        public static averagedInputLag AveragePreProecessedResults(List<inputLagResult> res)
        {
            // This is the function to process clicks type measurements 
            averagedInputLag inputLag = new averagedInputLag();

            List<inputLagResult> processedResults = inputLagOutlierRejection(res, true);
            inputLag.inputLagResults = processedResults;
            return averageResults(inputLag);
        }

        public static double GetMedian(double[] sourceNumbers)
        {
            //Framework 2.0 version of this method. there is an easier way in F4        
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new System.Exception("Median of empty array not defined.");

            //make sure the list is sorted, but use a new array
            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        public static List<inputLagResult> inputLagOutlierRejection(List<inputLagResult> res, bool removeOutliers = false)
        {
            // Consider adding actual outlier rejection like response time averaging...
            List<double> resultsList = new List<double>();

            List<inputLagResult> newRes = new List<inputLagResult>();
            newRes.AddRange(res);
            
                foreach (var i in res)
                {
                    if (i.onDisplayLatency == 0 )// && res[0].Type == resultType.Light)
                    {
                        newRes.Remove(i);
                    }
                    resultsList.Add(i.totalInputLag);
                }

            List<inputLagResult> newRes2 = new List<inputLagResult>();
            newRes2.AddRange(newRes);
            // find median of results
            double median = GetMedian(resultsList.ToArray());
            if (removeOutliers)
            {
                foreach (var i in newRes)
                {
                    if (i.totalInputLag > (median * 3) || i.totalInputLag < (median / 3))
                    {
                        newRes2.Remove(i);
                    }
                    else if (i.totalInputLag == 0)
                    {
                        newRes2.Remove(i);
                    }
                }
            }

            return newRes2;
        }

        public static averagedInputLag averageResults(averagedInputLag input)
        {
            averagedInputLag inputLagProcessed = input;
            // convert to double array for each type of average
            inputLagProcessed.ClickTime = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.FrameTime = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.onDisplayLatency = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.totalInputLag = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            for (int i = 0; i < inputLagProcessed.inputLagResults.Count; i++)
            {
                inputLagProcessed.ClickTime.AVG += inputLagProcessed.inputLagResults[i].clickTimeMs;
                inputLagProcessed.FrameTime.AVG += inputLagProcessed.inputLagResults[i].frameTimeMs;
                inputLagProcessed.onDisplayLatency.AVG += inputLagProcessed.inputLagResults[i].onDisplayLatency;
                inputLagProcessed.totalInputLag.AVG += inputLagProcessed.inputLagResults[i].totalInputLag;
                if (inputLagProcessed.inputLagResults[i].clickTimeMs < inputLagProcessed.ClickTime.MIN)
                {
                    inputLagProcessed.ClickTime.MIN = inputLagProcessed.inputLagResults[i].clickTimeMs;
                }
                else if (inputLagProcessed.inputLagResults[i].clickTimeMs > inputLagProcessed.ClickTime.MAX)
                {
                    inputLagProcessed.ClickTime.MAX = inputLagProcessed.inputLagResults[i].clickTimeMs;
                }
                if (inputLagProcessed.inputLagResults[i].frameTimeMs < inputLagProcessed.FrameTime.MIN)
                {
                    inputLagProcessed.FrameTime.MIN = inputLagProcessed.inputLagResults[i].frameTimeMs;
                }
                else if (inputLagProcessed.inputLagResults[i].frameTimeMs > inputLagProcessed.FrameTime.MAX)
                {
                    inputLagProcessed.FrameTime.MAX = inputLagProcessed.inputLagResults[i].frameTimeMs;
                }
                if (inputLagProcessed.inputLagResults[i].onDisplayLatency < inputLagProcessed.onDisplayLatency.MIN)
                {
                    inputLagProcessed.onDisplayLatency.MIN = inputLagProcessed.inputLagResults[i].onDisplayLatency;
                }
                else if (inputLagProcessed.inputLagResults[i].onDisplayLatency > inputLagProcessed.onDisplayLatency.MAX)
                {
                    inputLagProcessed.onDisplayLatency.MAX = inputLagProcessed.inputLagResults[i].onDisplayLatency;
                }
                if (inputLagProcessed.inputLagResults[i].totalInputLag < inputLagProcessed.totalInputLag.MIN)
                {
                    inputLagProcessed.totalInputLag.MIN = inputLagProcessed.inputLagResults[i].totalInputLag;
                }
                else if (inputLagProcessed.inputLagResults[i].totalInputLag > inputLagProcessed.totalInputLag.MAX)
                {
                    inputLagProcessed.totalInputLag.MAX = inputLagProcessed.inputLagResults[i].totalInputLag;
                }
            }
            inputLagProcessed.ClickTime.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.ClickTime.AVG = Math.Round(inputLagProcessed.ClickTime.AVG, 3);
            inputLagProcessed.FrameTime.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.FrameTime.AVG = Math.Round(inputLagProcessed.FrameTime.AVG, 3);
            inputLagProcessed.onDisplayLatency.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.onDisplayLatency.AVG = Math.Round(inputLagProcessed.onDisplayLatency.AVG, 3);
            inputLagProcessed.totalInputLag.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.totalInputLag.AVG = Math.Round(inputLagProcessed.totalInputLag.AVG, 3);
            return inputLagProcessed;
        }

    }

}

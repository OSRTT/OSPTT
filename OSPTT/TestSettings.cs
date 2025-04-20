using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace OSPTT
{
    public class TestSettings
    {
        public string Name { get; set; }
        public List<double> ActuationForces { get; set; }
        public int InitialForce { get; set; }
        public int OperatingForce { get; set; }
        public int EndForce { get; set; }
        public int DPI { get; set; }

        public ProcessData.resultType ResultType { get; set; }

    }
}

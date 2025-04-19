using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace OSPTT
{
    public class BoardId
    {
        public int Id { get; set; }
        public int Calibration { get; set; }
        
    }
    public class BoardIdList
    {
        public List<BoardId> Boards { get; set; }
    }
}

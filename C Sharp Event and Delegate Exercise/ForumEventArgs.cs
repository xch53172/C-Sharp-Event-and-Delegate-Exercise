using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Event_and_Delegate_Exercise
{
    public class ForumEventArgs:EventArgs
    {
        public Article Article { get; set; }
    }
}

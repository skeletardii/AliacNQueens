using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACT4
{
    public class StateHeuristic
    {
        public SixState State { get; set; }
        public int Heuristic { get; set; }

        public StateHeuristic(SixState state, int heuristic)
        {
            State = state;
            Heuristic = heuristic;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRovers.Data
{
    public class Rover
    {
        public int RoverNumber { get; set; }
        public string Instructions { get; set; }
        public List<Coordinates> coordinates { get; set; }
    }

    public class Coordinates
    {
        public int X { get; set; }    //canvas width coordinate
        public int Y { get; set; }   //canvas height coordinate
        public string Direction { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    public class Engine
    {
        public int Volume { get; set; }
        public EngineType EngineType { get; set; }
    }

    public enum EngineType
    {
        Vtype,
        Linear,
        FourCylinder
    }
}

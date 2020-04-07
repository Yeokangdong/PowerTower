using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerTower
{
    public class AnalysisResult
    {
        public ResultRod rod;
        public ResultTtype tType;

        public AnalysisResult()
        {
            rod = new ResultRod();
            tType = new ResultTtype();
        }
    }

    public class ResultRod
    {
        public double error;
        public double depth;
        public double tickness;

    }

    public class ResultTtype
    {
        public double depth;
        public double length;
        public double thickness;
    }

}

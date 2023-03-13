using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CubeChecker
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            
            return volume > 0 && volume == Math.Pow(side, 3); //literal boolean remove (? true : false)
        }
    }
}

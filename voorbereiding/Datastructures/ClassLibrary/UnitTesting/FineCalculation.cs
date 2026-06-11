using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.UnitTesting
{
    public class FineCalculation
    {
        public static int CalculateFine(int speed, int speedLimit, bool inSchoolZone)
        {
            int fine = 0;

            if (speed <= speedLimit)
                return 0;
            else if (speed <= speedLimit + 9)
                fine = 50;
            else if (speed < speedLimit + 20)
                fine = 100;
            else
                fine = 200;

            return fine + (inSchoolZone ? 50 : 0);
        }
    }
}

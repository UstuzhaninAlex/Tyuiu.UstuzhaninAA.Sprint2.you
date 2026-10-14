using System;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task0.V18.Lib
{
    public class DataService
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // x = 5105, y = 475
            // Ожидаеться: [False, True, True, True, True, False]
            bool[] res = new bool[6];

            res[0] = x == y;  // == (False)
            res[1] = x != y;  // != (True)
            res[2] = y < x;   // <  (True)
            res[3] = x > y;   // >  (True)
            res[4] = y <= x;  // <= (True)
            res[5] = y >= x;  // >= (False)

            return res;
        }
    }
}


using System;

namespace Open_Lab_03._07
{
    public class Divider
    {
        public bool EqualSlices(int total, int people, int each)
        {
            int calculation = people * each;
            if ((calculation < total) || (calculation == total))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

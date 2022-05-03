using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDifferenceInDays(DateTime first, DateTime second)
        {
            if(first.CompareTo(second) == -1)
            {
                return (int)(second - first).TotalDays;
            }
            else
            {
                return (int)(first - second).TotalDays;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    public class Checker
    {
        public int DaysInMonth(int? year, int? month)
        {
            if (!year.HasValue || !month.HasValue)
            {
                return 0;
            }

            if (year < 1000 || year > 3000)
            {
                return 0;
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if (month == 2)
            {
                if (year % 400 == 0)
                {
                    return 29;
                }
                else if (year % 100 == 0)
                {
                    return 28;
                }
                else if (year % 4 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                return 0;
            }
        }


        public bool IsValidDate(int? year, int? month, int? day)
        {
            if (day==null||month==null||year==null)
            {
                return false;
            }

            if (year < 1000 || year > 3000)
            {
                return false;
            }

            if (month >= 1 && month <= 12)
            {
                if (day >= 1)
                {
                    if (day <= DaysInMonth(year, month))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

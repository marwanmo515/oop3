﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal class HiringDate
    {
        #region att
        private int day;
        private int month;
        private int year;
        #endregion

        #region constructor
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region prop
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        #endregion

        #region methods
        public override string ToString() {
            return $"{day}/{month}/{year}";
        }
        #endregion
    }
}

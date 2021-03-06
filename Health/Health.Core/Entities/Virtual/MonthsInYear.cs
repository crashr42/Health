﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Health.Core.Entities.Virtual
{
    /// <summary>
    /// Месяцы в году.
    /// </summary>
    public static class MonthsInYear
    {
        private static readonly Dictionary<int, Month> _months = new Dictionary<int, Month>
                                                                     {
                                                                         {1, new Month {Name = "Январь", InYear = 1}},
                                                                         {2, new Month {Name = "Февраль", InYear = 2}},
                                                                         {3, new Month {Name = "Март", InYear = 3}},
                                                                         {4, new Month {Name = "Апрель", InYear = 4}},
                                                                         {5, new Month {Name = "Май", InYear = 5}},
                                                                         {6, new Month {Name = "Июнь", InYear = 6}},
                                                                         {7, new Month {Name = "Июль", InYear = 7}},
                                                                         {8, new Month {Name = "Август", InYear = 8}},
                                                                         {9, new Month {Name = "Сентябрь", InYear = 9}},
                                                                         {10, new Month {Name = "Октябрь", InYear = 10}},
                                                                         {11, new Month {Name = "Ноябрь", InYear = 11}},
                                                                         {12, new Month {Name = "Декабрь", InYear = 12}},
                                                                         {13, new Month {Name = "Все"}}
                                                                     };

        /// <summary>
        /// Январь.
        /// </summary>
        public static readonly Month January = _months[1];

        /// <summary>
        /// Февраль.
        /// </summary>
        public static readonly Month February = _months[2];

        /// <summary>
        /// Март.
        /// </summary>
        public static readonly Month March = _months[3];

        /// <summary>
        /// Апрель.
        /// </summary>
        public static readonly Month April = _months[4];

        /// <summary>
        /// Май.
        /// </summary>
        public static readonly Month May = _months[5];

        /// <summary>
        /// Июнь.
        /// </summary>
        public static readonly Month June = _months[6];

        /// <summary>
        /// Июль.
        /// </summary>
        public static readonly Month July = _months[7];

        /// <summary>
        /// Август.
        /// </summary>
        public static readonly Month August = _months[8];

        /// <summary>
        /// Сентябрь.
        /// </summary>
        public static readonly Month September = _months[9];

        /// <summary>
        /// Октябрь.
        /// </summary>
        public static readonly Month October = _months[10];

        /// <summary>
        /// Ноябрь.
        /// </summary>
        public static readonly Month November = _months[11];

        /// <summary>
        /// Декабрь.
        /// </summary>
        public static readonly Month December = _months[12];

        /// <summary>
        /// Любой месяц.
        /// </summary>
        public static readonly Month All = _months[13];

        /// <summary>
        /// Получить месяц по его номеру.
        /// </summary>
        /// <param name="index">Номер месяца.</param>
        /// <returns>Месяц.</returns>
        public static Month Month(int index)
        {
            return (index <= _months.Count & index > 0) ? _months[index] : null;
        }

        /// <summary>
        /// Получить месяц по его имени.
        /// </summary>
        /// <param name="name">Имя месяца.</param>
        /// <returns>Месяц.</returns>
        public static Month Month(string name)
        {
            foreach (var month in _months)
            {
                if (month.Value.Name == name)
                {
                    return month.Value;
                }
            }
            throw new Exception("Неверное имя месяца.");
        }

        /// <summary>
        /// Получить все месяцы.
        /// </summary>
        /// <returns>Месяцы.</returns>
        public static IEnumerable<Month> GetAll()
        {
            return _months.Values.AsEnumerable();
        }
    }
}
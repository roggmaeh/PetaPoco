﻿using System;

namespace PetaPoco
{
    public static class DateTime2Extensions
    {
        /// <summary>
        /// Converts an object to its <see cref="DateTime2"/> representation
        /// </summary>
        /// <param name="o">The object to be converted</param>
        /// <returns></returns>
        public static DateTime2 ToDateTime2(this object o) => new DateTime2((DateTime)o);
    }
}
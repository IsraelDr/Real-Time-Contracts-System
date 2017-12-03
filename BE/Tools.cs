﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    static class Tools
    {
        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            foreach (PropertyInfo item in t.GetType().GetProperties())
                str += "\n" + item.Name + ": " + item.GetValue(t, null);
            return str;
        }
    }
}

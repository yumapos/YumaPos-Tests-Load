﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Server.Data.Helpers
{
    public static class Class1
    {
        public static DataTable CopyGenericToDataTable<T>(this IEnumerable<T> items)
        {
            var properties = typeof(T).GetProperties();
            var result = new DataTable();

            //Build the columns
            foreach (var prop in properties)
            {
                var t = prop.PropertyType;
                if (t.FullName.Contains("YumaPos.Tests.Load.Server.Data")) continue;
                if (t.Name.StartsWith("Nullable")) t = t.GenericTypeArguments[0];
                result.Columns.Add(prop.Name, t);
            }

            //Fill the DataTable
            foreach (var item in items)
            {
                var row = result.NewRow();

                foreach (var prop in properties)
                {
                    var itemValue = prop.GetValue(item, new object[] { });
                    if (itemValue != null)
                    {
                        if (itemValue.GetType().FullName.Contains("YumaPos.Tests.Load.Server.Data")) continue;
                        row[prop.Name] = itemValue;
                    }
                }

                result.Rows.Add(row);
            }

            return result;
        }
    }
}

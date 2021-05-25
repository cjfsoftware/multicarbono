using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Filter
{
    public class FilterProp
    {
        public string Key { get; set; }
        public string FieldRef { get; set; }
        public string DisplayName { get; set; }

        //public FilterType Type { get; set; }
        public string DbType { get; set; }
        public string[] Options { get; set; }

        //public List<FilterOptionWithValue> OptionsWithValue { get; set; }

        //public List<FilterListItemProp> ListItemOptions { get; set; }

        public string Value { get; set; }

        public Tuple<string, string, bool>[] ArrayValues { get; set; }

        public DateTime DateTime { get; set; }
        public string DataSource { get; set; }

        public bool HasDataSource => !string.IsNullOrEmpty(DataSource);

        //public static FilterProp Create(string key, string fieldRef, string displayName, FilterType type, string[] options = null, List<FilterListItemProp> listItemOptions = null)
        //{
        //    return new FilterProp()
        //    {
        //        Key = key,
        //        FieldRef = fieldRef,
        //        DisplayName = displayName,
        //        Type = type,
        //        Options = options,
        //        ListItemOptions = listItemOptions
        //    };
        //}

        public static FilterProp Create(string key, string fieldRef, string displayName)
        {
            return new FilterProp()
            {
                Key = key,
                FieldRef = fieldRef,
                DisplayName = displayName,
                //Type = GetTypeByName(key),
            };
        }

        //private static FilterType GetTypeByName(string key)
        //{
        //    var tag = key[0].ToString();

        //    switch (tag)
        //    {
        //        case "D":
        //            return FilterType.DatePick;
        //        case "T":
        //            return FilterType.TextBox;
        //        case "C":
        //            return FilterType.Combobox;
        //        case "H":
        //            return FilterType.Check;
        //        case "R":
        //            return FilterType.Radio;
        //        default:
        //            return FilterType.TextBox;
        //    }
        //}

    }
}

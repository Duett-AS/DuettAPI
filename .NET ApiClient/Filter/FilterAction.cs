using System.Collections.Generic;

namespace Duett.Filter
{
    public class FilterAction
    {
        public List<FilterOperation> Operations { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public Dictionary<bool, string> OrderBy { get; set; }


        public FilterAction()
        {
            Operations = new List<FilterOperation>();
            OrderBy = new Dictionary<bool, string>();
            Take = 0;
            Skip = 0;
        }


        public List<KeyValuePair<string, string>> ToKeyValueList()
        {

            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            foreach (var o in Operations)
            {
                foreach (var value in o.Values)
                {
                    list.Add(new KeyValuePair<string, string>(string.Format("filter[{0}][{1}]", o.Property, (object) o.Operator), $"{value}"));
                }
               
            }
            if (Take != 0)
                list.Add(new KeyValuePair<string, string>($"filter[take]", $"{Take}"));
            if (Skip != 0)
                list.Add(new KeyValuePair<string, string>($"filter[skip]", $"{Skip}"));
            foreach (var ob in OrderBy)
            {
                string dir = ob.Key == true ? "asc" : "desc";
                list.Add(new KeyValuePair<string, string>($"filter[orderby][{dir}]", $"{ob.Value}"));
            }
            return list;

        }
    }
}
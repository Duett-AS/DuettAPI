using System;
using System.Collections.Generic;

namespace Duett.Filter
{
    public class FilterOperation
    {
        public string Property { get; set; }
        public Type PropertyType { get; set; }
        public FilterOperationType Operator { get; set; }
        public string SQLOperator { get; set; }
        public List<object> Values { get; set; }

        public FilterOperation(
            string property,
            Type propertyType,
            FilterOperationType op,
            List<object> values
        )
        {
            Property = property;
            PropertyType = propertyType;
            Operator = op;
            SQLOperator = ToSQLOperator(op);
            Values = values;
        }

        private string ToSQLOperator(FilterOperationType type)
        {
            switch (type)
            {
                case FilterOperationType.EQ:
                    return "=";
                case FilterOperationType.NEQ:
                    return "<>";
                case FilterOperationType.GT:
                    return ">";
                case FilterOperationType.GTE:
                    return ">=";
                case FilterOperationType.LT:
                    return "<";
                case FilterOperationType.LTE:
                    return "<=";
                case FilterOperationType.NIN:
                    return "NOT IN";
                default:
                    return Enum.GetName(type);
            }
        }
    }
}

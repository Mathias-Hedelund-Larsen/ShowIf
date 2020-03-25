using System;
using UnityEngine;

namespace HephaestusForge.ShowIf
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ShowIf : PropertyAttribute
    {
        [Flags]
        public enum Comparison
        {
            Equals = 1 << 0,
            GreaterThan = 1 << 1,
            LessThan = 1 << 2,
            NotEqualTo = 1 << 3
        }

        public string FieldName { get; }

        private IComparable _comparableValue;

        internal Func<IComparable, bool>[] _Compare;

        /// <summary>
        /// The field used with this constructor needs to be a bool, and will be shown if true
        /// </summary>
        public ShowIf(Comparison comparison = Comparison.Equals)
        {

        }

        /// <summary>
        /// The field used with this constructor will have its value checked, and will be shown if the value is equal
        /// </summary>
        /// <param name="value">The comparable value</param>
        public ShowIf(IComparable value)
        {
            _comparableValue = value;
        }

        /// <summary>
        /// The field name needs to refer to a bool field, and if the value is true this field will be shown
        /// </summary>
        /// <param name="fieldName">The name of the field</param>
        public ShowIf(string fieldName)
        {
            FieldName = fieldName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldName">The name of the field</param>
        /// <param name="value">The comparable value</param>
        public ShowIf(string fieldName, IComparable value)
        {
            _comparableValue = value;
            FieldName = fieldName;
        }

        private bool GreaterThan(IComparable comparable)
        {
            return comparable.CompareTo(_comparableValue) > 0;
        }

        private bool Equals(IComparable comparable)
        {
            return comparable.CompareTo(_comparableValue) == 0;
        }

        private bool GreaterLessThan(IComparable comparable)
        {
            return comparable.CompareTo(_comparableValue) < 0;
        }
    }
}

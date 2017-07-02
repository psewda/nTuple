using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tulip.Framework.Common;

namespace Tulip.Framework.Asserts
{
    public class StringAssert : BaseAssert, IStringAssert
    {
        #region Ctors

        /// <summary>
        /// Initializes the class with the specified source value and operator type.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="operator">The operator type.</param>
        public StringAssert(object source, OperatorType @operator) : base(source, @operator, AssertType.String)
        {

        }

        #endregion
        
        #region Null
        /// <summary>
        /// Asserts that the source value is null.
        /// </summary>
        public void Null()
        {
            this.Null(null);
        }

        /// <summary>
        /// Asserts that the source value is null.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        public void Null(string message)
        {
            const string assertName = nameof(this.Null);
            var source = (string)this.Source;
            var status = source == null;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <null> ";
                isMessage += $"but actually found <{source.ToString<string>()}>.";
                
                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <non null> ";
                isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                
                this.HandleFail(assertName, this.Source, null, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region Empty

        /// <summary>
        /// Asserts that the source value is empty.
        /// </summary>
        public void Empty()
        {
            this.Empty(null);
        }

        /// <summary>
        /// Asserts that the source value is empty.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        public void Empty(string message)
        {
            const string assertName = nameof(this.Empty);
            var isMessage = string.Empty;
            var isNotMessage = string.Empty;

            if (this.Source == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The source value cannot be null.";
                this.HandleFail(assertName, this.Source, string.Empty, isMessage, isNotMessage, message);
            }
            else
            {
                var source = (string)this.Source;
                var status = source == string.Empty;

                if (this.IsFailed(status))
                {
                    isMessage += $"The assert was expecting <empty> ";
                    isMessage += $"but actually found <{source.ToString<string>()}>.";

                    isNotMessage += $"The assert was expecting <non empty> ";
                    isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                    
                    this.HandleFail(assertName, this.Source, string.Empty, isMessage, isNotMessage, message);
                }
            }
        }

        #endregion

        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void EqualTo(string value)
        {
            this.EqualTo(value, false, null);
        }

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EqualTo(string value, string message)
        {
            this.EqualTo(value, false, message);
        }

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        public void EqualTo(string value, bool ignoreCase)
        {
            this.EqualTo(value, ignoreCase, null);
        }

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EqualTo(string value, bool ignoreCase, string message)
        {
            const string assertName = nameof(this.EqualTo);
            var source = (string)this.Source;
            var status = ignoreCase ? source.ToUpper<string>() == value.ToUpper<string>() : source == value;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <{value.ToString<string>()}> ";
                isMessage += $"but actually found <{source.ToString<string>()}>.";
                
                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value other than {value.ToString<string>()}> ";
                isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region Containing

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void Containing(string value)
        {
            this.Containing(value, false, null);
        }

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void Containing(string value, string message)
        {
            this.Containing(value, false, message);
        }

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        public void Containing(string value, bool ignoreCase)
        {
            this.Containing(value, ignoreCase, null);
        }

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void Containing(string value, bool ignoreCase, string message)
        {
            const string assertName = nameof(this.Containing);
            var isMessage = string.Empty;
            var isNotMessage = string.Empty;

            if (this.Source == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The source value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else if (value == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The target value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else
            {
                var source = (string)this.Source;
                var status = this.isMatched((string)this.Source, value, ignoreCase);

                if (this.IsFailed(status))
                {
                    isMessage += $"The assert was expecting <any value containing {value.ToString<string>()}> ";
                    isMessage += $"but actually found <{source.ToString<string>()}>.";

                    isNotMessage += $"The assert was expecting <any value not containing {value.ToString<string>()}> ";
                    isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                    
                    this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
                }
            }
        }

        #endregion

        #region StartingWith

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void StartingWith(string value)
        {
            this.StartingWith(value, false, null);
        }

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void StartingWith(string value, string message)
        {
            this.StartingWith(value, false, message);
        }

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        public void StartingWith(string value, bool ignoreCase)
        {
            this.StartingWith(value, ignoreCase, null);
        }

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void StartingWith(string value, bool ignoreCase, string message)
        {
            const string assertName = nameof(this.StartingWith);
            var isMessage = string.Empty;
            var isNotMessage = string.Empty;

            if (this.Source == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The source value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else if (value == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The target value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else
            {
                var source = (string)this.Source;
                var status = this.isMatched((string)this.Source, string.Format("^{0}", value), ignoreCase);

                if (this.IsFailed(status))
                {
                    isMessage += $"The assert was expecting <any value starting with {value.ToString<string>()}> ";
                    isMessage += $"but actually found <{source.ToString<string>()}>.";

                    isNotMessage += $"The assert was expecting <any value not starting with {value.ToString<string>()}> ";
                    isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                    
                    this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
                }
            }
        }

        #endregion

        #region EndingWith

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void EndingWith(string value)
        {
            this.EndingWith(value, false, null);
        }

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EndingWith(string value, string message)
        {
            this.EndingWith(value, false, message);
        }

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        public void EndingWith(string value, bool ignoreCase)
        {
            this.EndingWith(value, ignoreCase, null);
        }

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EndingWith(string value, bool ignoreCase, string message)
        {
            const string assertName = nameof(EndingWith);
            var isMessage = string.Empty;
            var isNotMessage = string.Empty;

            if (this.Source == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The source value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else if (value == null)
            {
                isMessage = isNotMessage = "The parameter is invalid. The target value cannot be null.";
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
            else
            {
                var source = (string)this.Source;
                var status = this.isMatched((string)this.Source, string.Format("{0}$", value), ignoreCase);

                if (this.IsFailed(status))
                {
                    isMessage += $"The assert was expecting <any value ending with {value.ToString<string>()}> ";
                    isMessage += $"but actually found <{source.ToString<string>()}>.";

                    isNotMessage += $"The assert was expecting <any value not ending with {value.ToString<string>()}> ";
                    isNotMessage += $"but actually found <{source.ToString<string>()}>.";
                    
                    this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
                }
            }
        }

        #endregion
        
        #region Valid

        /// <summary>
        /// Asserts that the source value is valid.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        public void Valid(Action<Expression<string>> validator)
        {
            this.InvokeValidator(validator, nameof(this.Valid));
        }

        #endregion

        #region Privates

        private bool isMatched(string input, string pattern, bool ignoreCase)
        {
            var regex = ignoreCase ? new Regex(pattern, RegexOptions.IgnoreCase) : new Regex(pattern);
            return regex.IsMatch(input);
        }
        
        #endregion
    }
}

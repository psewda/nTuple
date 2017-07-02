using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Common;

namespace Tulip.Framework.Asserts
{
    public class ObjectAssert<T> : BaseAssert, IObjectAssert<T>
    {
        #region Ctors

        /// <summary>
        /// Initializes the class with the specified source value and operator type.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="operator">The operator type.</param>
        public ObjectAssert(object source, OperatorType @operator) : base(source, @operator, AssertType.Object)
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
            var source = (T)this.Source;
            var status = source == null;

            if (this.IsFailed(status))
            {
                var isMessage = $"The assert was expecting <null> but actually found <non null>.";
                var isNotMessage = $"The assert was expecting <non null> but actually found <null>.";
                
                this.HandleFail(assertName, this.Source, null, isMessage, isNotMessage, message);
            }
        }


        #endregion

        #region Valid

        /// <summary>
        /// Asserts that the source value is valid.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        public void Valid(Action<Expression<T>> validator)
        {
            this.InvokeValidator(validator, nameof(this.Valid));
        }

        #endregion
    }
}

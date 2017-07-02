using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;

namespace Tulip.Framework
{
    public class Assert
    {
        #region String Assert

        /// <summary>
        /// Gets the string assert selector for comparing string values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The string assert selector for comparing string values.</returns>
        public static Selector<IStringAssert> That(string value)
        {
            return new Selector<IStringAssert>(value);
        }

        #endregion

        #region Numeric Assert

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<byte>> That(byte value)
        {
            return new Selector<INumberAssert<byte>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<sbyte>> That(sbyte value)
        {
            return new Selector<INumberAssert<sbyte>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<short>> That(short value)
        {
            return new Selector<INumberAssert<short>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<ushort>> That(ushort value)
        {
            return new Selector<INumberAssert<ushort>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<int>> That(int value)
        {
            return new Selector<INumberAssert<int>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<uint>> That(uint value)
        {
            return new Selector<INumberAssert<uint>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<long>> That(long value)
        {
            return new Selector<INumberAssert<long>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<ulong>> That(ulong value)
        {
            return new Selector<INumberAssert<ulong>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<float>> That(float value)
        {
            return new Selector<INumberAssert<float>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<double>> That(double value)
        {
            return new Selector<INumberAssert<double>>(value);
        }

        /// <summary>
        /// Gets the numeric assert selector for comparing numeric values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The numeric assert selector for comparing numeric values.</returns>
        public static Selector<INumberAssert<decimal>> That(decimal value)
        {
            return new Selector<INumberAssert<decimal>>(value);
        }

        #endregion

        #region Boolean Assert

        /// <summary>
        /// Gets the boolean assert selector for comparing boolean values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The boolean assert selector for comparing boolean values.</returns>
        public static Selector<IBoolAssert> That(bool value)
        {
            return new Selector<IBoolAssert>(value);
        }

        #endregion

        #region Object Assert

        /// <summary>
        /// Gets the object assert selector for comparing object values.
        /// </summary>
        /// <param name="value">The source value to compare.</param>
        /// <returns>The object assert selector for comparing object values.</returns>
        public static Selector<IObjectAssert<T>> That<T>(T value)
        {
            return new Selector<IObjectAssert<T>>(value);
        }

        #endregion
    }
}

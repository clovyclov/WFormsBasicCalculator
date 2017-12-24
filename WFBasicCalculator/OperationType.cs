using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBasicCalculator
{
    /// <summary>
    /// A type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add,
        /// <summary>
        /// Subtracts one value away from another
        /// </summary>
        Minus,
        /// <summary>
        /// Divides a value by another
        /// </summary>
        Divide,
        /// <summary>
        /// Multiplies a value by another
        /// </summary>
        Multiply
    }
}

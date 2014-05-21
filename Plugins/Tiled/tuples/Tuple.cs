// --------------------------------------------------------------------------
// Functional Programming in .NET - Chapter 3
// --------------------------------------------------------------------------
// NOTE: This library contains several useful classes for functional 
// programming in C# that we implemented in chapter 3 and that we'll 
// extend and use later in the book. Each secion is marked with a reference
// to a code listing or section in the book where it was discussed.
// --------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Eppy
{
    // Listing 3.8: Improved type inference for tuples in C#

    /// <summary>
    /// Utility class that simplifies cration of tuples by using 
    /// method calls instead of constructor calls
    /// </summary>
    public static class Tuple
    {
        /// <summary>
        /// Creates a new tuple value with the specified elements. The method 
        /// can be used without specifying the generic parameters, because C#
        /// compiler can usually infer the actual types.
        /// </summary>
        /// <param name="item1">First element of the tuple</param>
        /// <param name="second">Second element of the tuple</param>
        /// <returns>A newly created tuple</returns>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 second)
        {
            return new Tuple<T1, T2>(item1, second);
        }

        /// <summary>
        /// Creates a new tuple value with the specified elements. The method 
        /// can be used without specifying the generic parameters, because C#
        /// compiler can usually infer the actual types.
        /// </summary>
        /// <param name="item1">First element of the tuple</param>
        /// <param name="second">Second element of the tuple</param>
        /// <param name="third">Third element of the tuple</param>
        /// <returns>A newly created tuple</returns>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 second, T3 third)
        {
            return new Tuple<T1, T2, T3>(item1, second, third);
        }
        
        /// <summary>
        /// Creates a new tuple value with the specified elements. The method 
        /// can be used without specifying the generic parameters, because C#
        /// compiler can usually infer the actual types.
        /// </summary>
        /// <param name="item1">First element of the tuple</param>
        /// <param name="second">Second element of the tuple</param>
        /// <param name="third">Third element of the tuple</param>
        /// <param name="fourth">Fourth element of the tuple</param>
        /// <returns>A newly created tuple</returns>
        public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 second, T3 third, T4 fourth)
        {
            return new Tuple<T1, T2, T3, T4>(item1, second, third, fourth);
        }
    }
}

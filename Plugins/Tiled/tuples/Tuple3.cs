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
    // --------------------------------------------------------------------------
    // Section 3.2.2: Implementing tuple in C#

    // Listing 3.7: Implementing the tuple type in C#

    /// <summary>
    /// Represents a functional tuple that can be used to store 
    /// two values of different types inside one object.
    /// </summary>
    /// <typeparam name="T1">The type of the first element</typeparam>
    /// <typeparam name="T2">The type of the second element</typeparam>
    /// <typeparam name="T3">The type of the third element</typeparam>
    public sealed class Tuple<T1, T2, T3>
    {
        private readonly T1 item1;
        private readonly T2 item2;
        private readonly T3 item3;

        /// <summary>
        /// Retyurns the first element of the tuple
        /// </summary>
        public T1 Item1
        {
            get { return item1; }
        }

        /// <summary>
        /// Returns the second element of the tuple
        /// </summary>
        public T2 Item2
        {
            get { return item2; }
        }

        /// <summary>
        /// Returns the second element of the tuple
        /// </summary>
        public T3 Item3
        {
            get { return item3; }
        }

        /// <summary>
        /// Create a new tuple value
        /// </summary>
        /// <param name="item1">First element of the tuple</param>
        /// <param name="second">Second element of the tuple</param>
        /// <param name="third">Third element of the tuple</param>
        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + item1.GetHashCode();
            hash = hash * 23 + item2.GetHashCode();
            hash = hash * 23 + item3.GetHashCode();
            return hash;
        }

        public override bool Equals(object o)
        {
            if (o.GetType() != typeof(Tuple<T1, T2, T3>)) {
                return false;
            }

            var other = (Tuple<T1, T2, T3>)o;

            return this == other;
        }

        public static bool operator==(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
        {
            return 
                a.item1.Equals(b.item1) && 
                a.item2.Equals(b.item2) && 
                a.item3.Equals(b.item3);            
        }

        public static bool operator!=(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
        {
            return !(a == b);
        }

        public void Unpack(Action<T1, T2, T3> unpackerDelegate)
        {
            unpackerDelegate(Item1, Item2, Item3);
        }
    }
}

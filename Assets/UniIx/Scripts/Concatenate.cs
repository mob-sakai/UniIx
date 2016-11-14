// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System;
using System.Collections.Generic;
using System.Linq;


namespace System.Linq
{
    public static partial class EnumerableEx
    {
        /// <summary>
        ///     Concatenates the input sequences.
        /// </summary>
        /// <typeparam name="TSource">Source sequence element type.</typeparam>
        /// <param name="sources">Source sequences.</param>
        /// <returns>Sequence with the elements of the source sequences concatenated.</returns>
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<IEnumerable<TSource>> sources)
        {
            if (sources == null)
                throw new ArgumentNullException("sources");

			return Concat_(sources);
        }

        /// <summary>
        ///     Concatenates the input sequences.
        /// </summary>
        /// <typeparam name="TSource">Source sequence element type.</typeparam>
        /// <param name="sources">Source sequences.</param>
        /// <returns>Sequence with the elements of the source sequences concatenated.</returns>
        public static IEnumerable<TSource> Concat<TSource>(params IEnumerable<TSource>[] sources)
        {
            if (sources == null)
                throw new ArgumentNullException("sources");

			return Concat_(sources);
        }

		/// <summary>
		///     Concatenates the input sequences.
		/// </summary>
		/// <typeparam name="TSource">Source sequence element type.</typeparam>
		/// <param name="source">Source sequence.</param>
		/// <param name="values">Values to sufix the sequence with.</param>
		/// <returns>Sequence with the elements of the source sequences concatenated.</returns>
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> source, params TSource[] values)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			return Enumerable.Concat(source, values);
		}

        private static IEnumerable<TSource> Concat_<TSource>(this IEnumerable<IEnumerable<TSource>> sources)
        {
            foreach (var source in sources)
                foreach (var item in source)
                    yield return item;
        }
    }
}
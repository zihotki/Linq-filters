using System;
using System.Linq.Expressions;

namespace LinqFilters
{
    /// <summary>
    /// Enables the efficient, dynamic composition of query predicates.
    /// </summary>
    public static class FilterExpressionBuilder
    {
        /// <summary>
        /// Combines the first predicate with the second using the logical "and".
        /// </summary>
        public static FilterExpression<T> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.ToEasyPredicate<T>().And(second);
        }

        /// <summary>
        /// Combines the first predicate with the second using the logical "or".
        /// </summary>
        public static FilterExpression<T> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.ToEasyPredicate<T>().Or(second);
        }

        /// <summary>
        /// Negates the predicate.
        /// </summary>
        public static FilterExpression<T> Not<T>(this Expression<Func<T, bool>> expression)
        {
            return expression.ToEasyPredicate<T>().Not();
        }

        public static FilterExpression<T> ToEasyPredicate<T>(this Expression<Func<T, bool>> expression)
        {
            return FilterExpression<T>.Create(expression);
        }
    }
}
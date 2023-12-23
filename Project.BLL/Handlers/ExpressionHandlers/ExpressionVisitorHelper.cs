using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Handlers.ExpressionHandlers
{
    public static class ExpressionVisitorHelper
    {
        public static Expression<Func<TTarget, bool>> ReplaceVisitor<TSource, TTarget>(Expression<Func<TSource, bool>> expression)
        {
            ReplaceExpressionVisitor<TSource, TTarget> visitor = new ReplaceExpressionVisitor<TSource, TTarget>(expression.Parameters[0]);

            return Expression.Lambda<Func<TTarget, bool>>(visitor.Visit(expression.Body), visitor.NewParameterExpression);

        }

        public static Expression<Func<TTarget, X>> ReplaceVisitor<TSource, TTarget, X>(Expression<Func<TSource, X>> expression)
        {
            ReplaceExpressionVisitor<TSource, TTarget> visitor = new ReplaceExpressionVisitor<TSource, TTarget>(expression.Parameters[0]);
            return Expression.Lambda<Func<TTarget, X>>(visitor.Visit(expression.Body), visitor.NewParameterExpression);
        }

        public static Expression<Func<TTarget, object>> ReplaceVisitor<TSource, TTarget>(Expression<Func<TSource, object>> expression)
        {
            ReplaceExpressionVisitor<TSource, TTarget> visitor = new ReplaceExpressionVisitor<TSource, TTarget>(expression.Parameters[0]);

            return Expression.Lambda<Func<TTarget, object>>(visitor.Visit(expression.Body), visitor.NewParameterExpression);
        }
    }
}

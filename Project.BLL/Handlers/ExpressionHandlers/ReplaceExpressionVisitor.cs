using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Handlers.ExpressionHandlers
{
    public class ReplaceExpressionVisitor<TSource, TTarget> : ExpressionVisitor
    {
        private readonly ParameterExpression _oldParameterExpression;
        public ParameterExpression NewParameterExpression { get; }

        public ReplaceExpressionVisitor(ParameterExpression oldParameterExpression)
        {
            _oldParameterExpression = oldParameterExpression;
            NewParameterExpression = Expression.Parameter(typeof(TTarget), oldParameterExpression.Name);
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return node == _oldParameterExpression ? NewParameterExpression : base.VisitParameter(node);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            Expression? newExpression = Visit(node.Expression);
            if (newExpression == node.Expression)
            {
                return node;
            }
            var member = typeof(TTarget).GetMember(node.Member.Name).FirstOrDefault();
            if (member == null)
            {
                return node;
            }

            return Expression.MakeMemberAccess(newExpression, member);
        }
    }
}

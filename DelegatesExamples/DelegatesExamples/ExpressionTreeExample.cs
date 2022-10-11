using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ExpressionTreeExample
    {
        public void ExpressionTree()
        {
            //Express tree (3+5)-(4-2)
            //3+5
            BinaryExpression Exp1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(3),
                Expression.Constant(5));
            //4-2
            BinaryExpression Exp2 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(4),
                Expression.Constant(2));
            // (3+5)-(4-2)
            BinaryExpression resultExp = Expression.MakeBinary(ExpressionType.Subtract, Exp1, Exp2);
            //this stmt will create a delegates by parsing the expression three
            int result = Expression.Lambda<Func<int>>(resultExp).Compile()();
            Console.WriteLine("result={0}", result);
        }
    }
}

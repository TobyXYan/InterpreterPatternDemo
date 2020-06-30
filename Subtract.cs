using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPatternDemo
{
    class Subtract : RpnExpression
    {
        protected RpnExpression _lhs = null;
        protected RpnExpression _rhs = null;


        public Subtract(RpnExpression lhs, RpnExpression rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        public override int Interpret()
        {
            return _lhs.Interpret() - _rhs.Interpret();
        }
    }
}

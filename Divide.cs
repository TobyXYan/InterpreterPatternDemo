using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPatternDemo
{
    class Divide : RpnExpression
    {
        protected RpnExpression _lhs = null;
        protected RpnExpression _rhs = null;


        public Divide(RpnExpression lhs, RpnExpression rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        public override int Interpret()
        {
            return _lhs.Interpret() / _rhs.Interpret();
        }
    }
}

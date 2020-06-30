using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPatternDemo
{
    class Number : RpnExpression
    {

        protected int _value = 0;

        public Number(int value)
        {
            _value = value;
        }

        public override int Interpret()
        {
            return _value;
        }
    }
}

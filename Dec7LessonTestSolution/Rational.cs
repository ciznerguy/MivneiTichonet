using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec7LessonTestSolution
{
    internal class Rational
    {
        private int mone;
        private int mechane;

        public Rational(int mone, int mechane)
        {
            this.mone = mone;
            this.mechane = mechane;
        }

        public Rational()
        {
        }

        public int GetMone()
        {
            return mone;
        }

        public int GetMechane()
        {
            return mechane;
        }

        public override string ToString()
        {
            return $" mone =    {mone} \n mechane = {mechane}";
        }
    }
}

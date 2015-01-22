using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    internal class MedianFilter : Filter
    {
        internal MedianFilter(int length)
            : base(length)
        {

        }

        public override double Calculate()
        {
            List<double> tmp = base.buffer.ToList();
            tmp.Sort();
            return tmp[tmp.Count / 2];
        }
    }
}

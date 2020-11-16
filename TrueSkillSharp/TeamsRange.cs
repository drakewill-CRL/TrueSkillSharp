using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSkillSharp.Numerics;

namespace TrueSkillSharp
{
    public class TeamsRange : Range<TeamsRange>
    {
        public TeamsRange()
            : base(int.MinValue, int.MinValue)
        {
        }

        private TeamsRange(int min, int max)
            : base(min, max)
        {
        }

        protected override TeamsRange Create(int min, int max)
        {
            return new TeamsRange(min, max);
        }
    }
}

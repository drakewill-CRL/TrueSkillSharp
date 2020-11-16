using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSkillSharp.Numerics;

namespace TrueSkillSharp
{
    public class PlayersRange : Range<PlayersRange>
    {
        public PlayersRange()
            : base(int.MinValue, int.MinValue)
        {
        }

        private PlayersRange(int min, int max)
            : base(min, max)
        {
        }

        protected override PlayersRange Create(int min, int max)
        {
            return new PlayersRange(min, max);
        }
    }
}

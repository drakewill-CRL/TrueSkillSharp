using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueSkillSharp.Elo
{
    public class EloRating : Rating
    {
        public EloRating(double rating)
            : base(rating, 0)
        {
        }
    }
}

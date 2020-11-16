using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueSkillSharp
{
    public class GameInfo
    {
        private const double DefaultBeta = DefaultInitialMean / 6.0;
        private const double DefaultDrawProbability = 0.10;
        private const double DefaultDynamicsFactor = DefaultInitialMean / 300.0;
        private const double DefaultInitialMean = 25.0;
        private const double DefaultInitialStandardDeviation = DefaultInitialMean / 3.0;

        public GameInfo(double initialMean, double initialStandardDeviation, double beta, double dynamicFactor,
                        double drawProbability)
        {
            InitialMean = initialMean;
            InitialStandardDeviation = initialStandardDeviation;
            Beta = beta;
            DynamicsFactor = dynamicFactor;
            DrawProbability = drawProbability;
        }

        public double InitialMean { get; set; }
        public double InitialStandardDeviation { get; set; }
        public double Beta { get; set; }

        public double DynamicsFactor { get; set; }
        public double DrawProbability { get; set; }

        public Rating DefaultRating
        {
            get { return new Rating(InitialMean, InitialStandardDeviation); }
        }

        public static GameInfo DefaultGameInfo
        {
            get
            {
                // We return a fresh copy since we have public setters that can mutate state
                return new GameInfo(DefaultInitialMean,
                                    DefaultInitialStandardDeviation,
                                    DefaultBeta,
                                    DefaultDynamicsFactor,
                                    DefaultDrawProbability);
            }
        }
    }
}

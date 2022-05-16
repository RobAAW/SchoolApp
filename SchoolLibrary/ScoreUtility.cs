using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored AssignmentOne, IScored AssignmentTwo)
        {
            var scoreOne = AssignmentOne.Score / AssignmentOne.MaximumScore;
            var scoreTwo = AssignmentTwo.Score / AssignmentTwo.MaximumScore;

            if (scoreOne > scoreTwo)
            {
                return AssignmentOne;
            }
            else
            {
                return AssignmentTwo;
            }
        }
    }
}

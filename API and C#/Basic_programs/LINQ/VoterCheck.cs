using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class VoterCheck
    {
        public static List<People> where(People[] people,EligibleCheck del) {
            List<People> voters = new List<People>();
            foreach(People person in people)
            {
                if (del(person))
                {
                    voters.Add(person);
                }
            }
            return voters;
        
        }
    }
}

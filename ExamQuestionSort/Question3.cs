using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    public class Question3 : Question
    {
        public override string Txt
        {
            get
            {
                return ("What markup language do RSS, Atom and OpenSearch use?");
            }
        }
        public override int Id
        {
            get
            {
                return (3);
            }
        }

        public override string HardshipLevel
        {
            get
            {
                return ("Medium");
            }
        }

        public override string Topic
        {
            get
            {
                return ("HTML");
            }
        }

        public override double Score
        {
            get
            {
                return (2);
            }
        }
    }

}

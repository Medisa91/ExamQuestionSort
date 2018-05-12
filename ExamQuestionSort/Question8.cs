using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    class Question8 : Question
    {
        public override string Txt
        {
            get
            {
                return ("The external JavaScript file must contain the <script> tag.");
            }
        }

        public override int Id
        {
            get
            {
                return (8);
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
                return ("JavaScript");
            }
        }

        public override double Score
        {
            get
            {
                return (2.5);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofSortQuestion
{
    public class Question2 : Question
    {
        public override string Txt
        {
            get
            {
                return ("Inside which HTML element do we put the JavaScript?");
            }
        }

        public override int Id
        {
            get
            {
                return (2);
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
                return (1.5);
            }
        }
    }

}
